/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package jdbcmysql;

import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.time.LocalDate;

/*
 * Actualiza el salario de los empleados de la tabla 'emp' fila a fila
 * mediante un ResultSet actualizable dentro de una única transacción.
 * A cada empleado se le aplica como máximo una subida según el orden indicado.
 */
public class ActualizarSalarios {

    public static void main(String[] args) {
        // Datos de conexión pedidos en el enunciado
        String url = "jdbc:mysql://localhost/empdept";
        String usuario = "root";
        String password = "";

        Connection conn = null;

        try {
            // 1. Abrimos conexión con MySQL
            conn = DriverManager.getConnection(url, usuario, password);

            // Desactivamos el autocommit para que TODO el recorrido sea una única transacción:
            // o se guardan todos los cambios juntos (commit) o se cancelan todos (rollback).
            conn.setAutoCommit(false);

            // 2. Creamos un Statement que permita moverse y actualizar filas directamente en el ResultSet
            Statement stmt = conn.createStatement(
                    ResultSet.TYPE_SCROLL_INSENSITIVE,
                    ResultSet.CONCUR_UPDATABLE
            );

            // Pedimos las columnas necesarias (incluimos la clave primaria 'empno' para que MySQL
            // pueda identificar sin ambigüedad qué fila actualizar en el ResultSet)
            String sql = "SELECT empno, ename, job, hiredate, sal, deptno FROM emp";
            ResultSet rs = stmt.executeQuery(sql);

            // Fecha límite de antigüedad: 01/09/1981 (anterior a esta fecha -> +15%)
            LocalDate fechaLimite = LocalDate.of(1981, 9, 1);

            int filasActualizadas = 0;

            // 3. Recorremos la tabla fila a fila
            while (rs.next()) {
                int empno = rs.getInt("empno");
                String ename = rs.getString("ename");
                String job = rs.getString("job");
                Date fechaSql = rs.getDate("hiredate");
                double salarioActual = rs.getDouble("sal");
                int deptno = rs.getInt("deptno");

                // Convertimos java.sql.Date a LocalDate para comparar fechas cómodamente
                LocalDate fechaAlta = (fechaSql != null) ? fechaSql.toLocalDate() : null;

                // Variable para saber si este empleado cumple alguna condición y cuánto sube
                double porcentajeSubida = 0.0;

                // MUY IMPORTANTE: Usamos 'if / else if' en el orden exacto del enunciado
                // para que a cada empleado se le aplique ÚNICAMENTE una subida.
                if ("MANAGER".equalsIgnoreCase(job)) {
                    // 1ª condición: Gerentes -> +10%
                    porcentajeSubida = 0.10;
                } else if (fechaAlta != null && fechaAlta.isBefore(fechaLimite)) {
                    // 2ª condición: Antigüedad anterior al 01/09/1981 -> +15%
                    porcentajeSubida = 0.15;
                } else if ("ANALYST".equalsIgnoreCase(job) && deptno == 20) {
                    // 3ª condición (resto): Analistas del departamento 20 -> +5%
                    porcentajeSubida = 0.05;
                } else if ("SALESMAN".equalsIgnoreCase(job) || "VENDEDOR".equalsIgnoreCase(job)) {
                    // 4ª condición (resto): Vendedores -> +8%
                    porcentajeSubida = 0.08;
                }

                // Solo tocamos la fila en la BD si le corresponde alguna subida
                if (porcentajeSubida > 0.0) {
                    double nuevoSalario = salarioActual * (1 + porcentajeSubida);

                    // Preparamos el nuevo valor en el ResultSet y confirmamos el cambio de esa fila
                    rs.updateDouble("sal", nuevoSalario);
                    rs.updateRow();

                    filasActualizadas++;
                    System.out.printf("Empleado %d (%s) | Subida: %.0f%% | Salario: %.2f -> %.2f%n",
                            empno, ename, porcentajeSubida * 100, salarioActual, nuevoSalario);
                } else {
                    System.out.printf("Empleado %d (%s) | Sin subida (Salario: %.2f)%n",
                            empno, ename, salarioActual);
                }
            }

            // 4. Si todo ha ido bien sin excepciones, confirmamos toda la transacción
            conn.commit();
            System.out.println("\nTransacción confirmada (COMMIT). Filas actualizadas: " + filasActualizadas);

        } catch (SQLException e) {
            // Si ocurre cualquier error en medio del proceso, deshacemos TODOS los cambios
            System.err.println("\nError en la operación. Ejecutando ROLLBACK...");
            if (conn != null) {
                try {
                    conn.rollback();
                    System.out.println("Rollback realizado: no se ha modificado ningún salario.");
                } catch (SQLException ex) {
                    System.err.println("Error al hacer rollback: " + ex.getMessage());
                }
            }
            e.printStackTrace();

        } finally {
            // 5. Cerramos la conexión de forma segura al terminar
            if (conn != null) {
                try {
                    conn.setAutoCommit(true);
                    conn.close();
                } catch (SQLException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}