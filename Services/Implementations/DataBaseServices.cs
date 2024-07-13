using Inventory.Models;
using Npgsql;
using System.Data;

namespace Inventory.Services.Implementations
{
    public class DataBaseServices : IDataBase
    {

        //Get Data From Data Base
        public DataTable GetData(DBSettings dbSettings, string tableTittle)
        {
            DataTable loadedData = new();


            string connectionString = $"Server={dbSettings.Server}; " +
                                      $"Port={dbSettings.Port}; " +
                                      $"DataBase={dbSettings.Name}; " +
                                      $"User Id={dbSettings.UserId}; " +
                                      $"Password={dbSettings.Password};";

            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand sqlCommand = new();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $"SELECT * FROM \"{tableTittle}\"";
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