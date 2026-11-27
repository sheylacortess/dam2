/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package proyectoprueba;

/**
 *
 * @author profesor
 */
import java.sql.*;

public class ConsultaPrueba {

    public static void main(String[] args) {
        // Declaramos los objetos fuera del try para poder cerrarlos en el finally
        Connection conexion = null;
        Statement sentencia = null;
        ResultSet resul = null;

        try {
            // 1. Establecer la conexión (URL, usuario por defecto "root", contraseña vacía "")
            conexion = DriverManager.getConnection("jdbc:mysql://localhost/emp_dept", "root", "");

            // 2. Crear el objeto Statement para poder lanzar consultas SQL
            sentencia = conexion.createStatement();

            // 3. Escribir y ejecutar la consulta SELECT
            String sql = "SELECT * FROM departamentos";
            resul = sentencia.executeQuery(sql);

            // 4. Recorrer el ResultSet fila por fila mientras haya registros
            while (resul.next()) {
                // Obtenemos los datos por el número de columna (1: dept_no, 2: dnombre, 3: loc)
                System.out.printf("%d, %s, %s %n",
                        resul.getInt(1),
                        resul.getString(2),
                        resul.getString(3));
            }

        } catch (SQLException e) {
            // Captura errores de conexión o de sintaxis SQL
            System.out.println("Error SQL: " + e.getMessage());
            e.printStackTrace();
        } finally {
            // 5. Liberar siempre los recursos en orden inverso a su apertura
            try {
                if (resul != null) {
                    resul.close();
                }
                if (sentencia != null) {
                    sentencia.close();
                }
                if (conexion != null) {
                    conexion.close();
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }
}
