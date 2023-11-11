package org.dbpractices;

import java.sql.Connection;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.DriverManager;

import com.microsoft.sqlserver.jdbc.SQLServerDriver;

public class App {
    public static void main(String[] args) {

        System.out.println("Connect to SQL Server ...");

        //Update the username and password below
        String connectionUrl = "jdbc:sqlserver://localhost:1433;databaseName=master;user=sa;password=SQLPassword!0;encrypt=true;trustServerCertificate=true";

        try {
            // Load SQL Server JDBC driver and establish connection.
            // Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            try (Connection connection = DriverManager.getConnection(connectionUrl)) {
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