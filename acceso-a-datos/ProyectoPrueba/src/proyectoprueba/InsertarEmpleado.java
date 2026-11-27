/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package proyectoprueba;

import java.util.Scanner;
import java.sql.*;
import java.time.LocalDate;

/**
 *
 * @author profesor
 */
public class InsertarEmpleado {
    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);
        Connection conexion = null;
        Statement sentencia = null;
        ResultSet rs = null;
        
        try {
            conexion = DriverManager.getConnection("jdbc:mysql://localhost/emp_dept", "root", "");
            sentencia = conexion.createStatement();
            
            System.out.println("Introduce el numero de empleado: ");
            int empNo = Integer.parseInt(sc.nextLine());
            System.out.println("Introduce el apellido: ");
            String apellido = sc.nextLine().trim();
            System.out.println("Introduce oficio: ");
            String oficio = sc.nextLine().trim();
            System.out.println("Introduce un numero de director: ");
            int dir = Integer.parseInt(sc.nextLine());
            System.out.println("Introduce salario: ");
            float salario = Float.parseFloat(sc.nextLine());
            System.out.println("Introduce comision: ");
            float comision = Float.parseFloat(sc.nextLine());
            System.out.println("Introduce el numero de departamento (DEPT_NO)");
            int deptNo = Integer.parseInt(sc.nextLine());
            
            if (apellido.isEmpty() || oficio.isEmpty()) {
                System.out.println("Error: El APELLIDO y el OFICIO tienen que estar rellenos");
                return;
            }
            if (salario <= 0) {
                System.out.println("Error: El salario debe ser positivo");
                return;
            }
            
            //ahora vamos a comprobar que el numero de empleado NO exista 
            rs = sentencia.executeQuery("SELECT dept_no FROM departamentos WHERE dept_no = " + deptNo);
            if (!rs.next()) {
                System.out.println("El departamento " + deptNo + " no existe. Creando departamento nuevo...");
                String sqlInsertDep = String.format(
                    "INSERT INTO departamentos VALUES (%d, 'NUEVO_DEP', 'SIN_LOC')", deptNo
                );
                sentencia.executeUpdate(sqlInsertDep);
                System.out.println("Departamento " + deptNo + " insertado correctamente.");
            }
            rs.close();

            // 5. Comprobar que el número de empleado NO exista
            rs = sentencia.executeQuery("SELECT emp_no FROM empleados WHERE emp_no = " + empNo);
            if (rs.next()) {
                System.out.println("ERROR: El número de empleado " + empNo + " ya existe en la base de datos.");
                return;
            }
            rs.close();

            // (Opcional pero recomendado según el enunciado: comprobar si el director existe)
            rs = sentencia.executeQuery("SELECT emp_no FROM empleados WHERE emp_no = " + dir);
            if (!rs.next()) {
                System.out.println("ERROR: El director con número " + dir + " no existe.");
                return;
            }
            rs.close();

            // 6. Obtener la fecha actual en formato YYYY-MM-DD para MySQL
            String fechaActual = LocalDate.now().toString();

            // 7. Construir y ejecutar el INSERT en la tabla empleados
            // Usamos Locale.US en String.format para que los decimales lleven punto (.) y no coma (,)
            String sqlInsertEmp = String.format(java.util.Locale.US,
                "INSERT INTO empleados VALUES (%d, '%s', '%s', %d, '%s', %.2f, %.2f, %d)",
                empNo, apellido.toUpperCase(), oficio.toUpperCase(), dir, fechaActual, salario, comision, deptNo
            );

            int filas = sentencia.executeUpdate(sqlInsertEmp);
            if (filas > 0) {
                System.out.println("ÉXITO: Empleado insertado correctamente (" + filas + " fila afectada).");
            }
            
        } catch (NumberFormatException e) {
            System.out.println("Error de formato");
        } catch (SQLException e) {
            System.out.println("Error SQL : " + e.getMessage());
        }finally {
            // 8. Liberar recursos
            try {
                if (rs != null) rs.close();
                if (sentencia != null) sentencia.close();
                if (conexion != null) conexion.close();
                sc.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }    
    }
}
