package org.dbpractices;

import java.sql.Connection;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.DriverManager;

public class App {
   public static void main(String[] args) {
        System.out.println("Connect to pgsql server ...");

        //Update the username and password below
        String connectionUrl = "jdbc:postgresql://localhost:5432/postgres";

        try {
            // Load SQL Server JDBC driver and establish connection.
            // Class.forName("org.postgresql.Driver");
            try (Connection connection = DriverManager.getConnection(connectionUrl, "postgres", "SQLPassword")) {
                String sql = "SELECT 'Hello World' as message";
                try (Statement statement = connection.createStatement();
                     ResultSet resultSet = statement.executeQuery(sql))
                {
                    while (resultSet.next()) {
                        System.out.println(resultSet.getString(1));
                    }
                }

                System.out.println("All done.");
            }
        } catch (Exception e) {
            System.out.println();
            e.printStackTrace();
        }
    }
}