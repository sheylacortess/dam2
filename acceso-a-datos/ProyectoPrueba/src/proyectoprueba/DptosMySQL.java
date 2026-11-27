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

public class DptosMySQL {

    public static void main(String[] args) {
        try {
            Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/emp_dept", "root", ""); // Establecemos la conexión con la BD
            Statement sentencia = conexion.createStatement();
            String sql = "SELECT * FROM departamentos";
            ResultSet resul = sentencia.executeQuery(sql); //El objeto Resulset guarda el resultado de la consulta
            while (resul.next()) { // Recorrer para visualizar cada fila. Mientras haya registros será true
                System.out.printf("%d, %s, %s %n", resul.getInt(1), resul.getString(2), resul.getString(3));
            }
            //getInt(), getString(), getDate() van obteniendo los datos del tipo que corresponda a la posición del parámetro.
            //También puede indicarse mediante el nombre del campo
            resul.close(); // Cerrar ResultSet
            sentencia.close(); // Cerrar Statement
            conexion.close(); // Cerrar conexión
        } catch (SQLException e) {
            e.printStackTrace();
        }
    } // fin de main
} // fin de la clase
