using System;
using MySql.Data.MySqlClient; // Import the MySQL namespace

class Program
{
    static void Main(string[] args)
    {
        // Define the connection string
        string connectionString = "Server=127.0.0.1;Database=sample_ip;User ID=root;Password=root;";

        // Create a connection to the MySQL database
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connection opened successfully.");

                // Define the SQL query
                string query = "SELECT * FROM ip_address_int limit 10";

                // Create a MySqlCommand
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the command and read the data
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Display each record's data
                            Console.WriteLine("ip_address: " + reader["ip_address"].ToString());
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
