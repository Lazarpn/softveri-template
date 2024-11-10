using Microsoft.Data.SqlClient;

namespace Database;

public class DatabaseBroker
{
    public SqlConnection connection;

    public DatabaseBroker()
    {
        InitializeConnection();
    }

    public void CloseConnection()
    {
        connection?.Close();
    }

    private void InitializeConnection()
    {
        try
        {
            connection = new SqlConnection("Data Source=LAZAR\\SQLEXPRESS;Initial Catalog=vezbe06;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            connection.Open();
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured.");
            throw;
        }
    }
}
