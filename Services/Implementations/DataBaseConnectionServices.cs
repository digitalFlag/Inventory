using Npgsql;
using System.Data;

namespace Inventory.Services.Implementations
{
    class DataBaseConnectionServices : IDataBaseConnection
    {
        public DataTable LoadData()
        {
            string connectionString = "Server=localhost; Port=5432; DataBase=Test_N; User Id=dinaster; Password=diM@$terPw_87;";

            DataTable loadedData = new();
            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand sqlCommand = new();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM \"Prodacts\"";
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