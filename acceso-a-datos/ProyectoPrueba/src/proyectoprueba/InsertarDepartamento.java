/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package proyectoprueba;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class InsertarDepartamento {

    public static void main(String[] args) {
        String url = "jdbc:oracle:thin:@localhost:1521/FREEPDB1"; // Ajusta host, puerto y servicio/SID
        String usuario = "sheyla";
        String password = "sheyla";

        String sql = "INSERT INTO departamentos (dept_no, dnombre, loc) VALUES (?, ?, ?)";

        try (Connection conn = DriverManager.getConnection(url, usuario, password);
             PreparedStatement pstmt = conn.prepareStatement(sql)) {

            pstmt.setInt(1, 50);
            pstmt.setString(2, "RRHH");
            pstmt.setString(3, "MADRID");

            int filasInsertadas = pstmt.executeUpdate();
            System.out.println("Filas insertadas: " + filasInsertadas);

        } catch (SQLException e) {
            System.err.println("Error al insertar el departamento: " + e.getMessage());
            e.printStackTrace();
        }
    }
}