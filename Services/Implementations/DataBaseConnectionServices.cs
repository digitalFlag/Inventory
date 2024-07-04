using Npgsql;
using System.Data;

namespace Inventory.Services.Implementations
{
    class DataBaseConnectionServices : IDataBaseConnection
    {
        public DataTable LoadDataFromTable(string server, string port, string dataBase, string userId, string password, string table)
        {
            string connectionString = $"Server={server}; Port={port}; DataBase={dataBase}; User Id={userId}; Password={password};";

            DataTable loadedData = new();
            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand sqlCommand = new();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $"SELECT * FROM \"{table}\"";
            NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                loadedData.Load(sqlDataReader);
            }
            sqlCommand.Dispose();
            sqlConnection.Close();

            return loadedData;
        }
    }
}