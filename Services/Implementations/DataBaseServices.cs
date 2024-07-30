using Inventory.Models;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory.Services.Implementations
{
    public class DataBaseServices : IDataBase
    {

        //ToDo It Is Need To Update "Get Data Method" To Made It Async

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

        // Update Record In Table From Data Base
        public async Task UpdateRecord(DBSettings dbSettings, string tableTittle, string columnTittle, string id, string newValue)
        {
            string connectionString = $"Server={dbSettings.Server}; " +
                                      $"Port={dbSettings.Port}; " +
                                      $"DataBase={dbSettings.Name}; " +
                                      $"User Id={dbSettings.UserId}; " +
                                      $"Password={dbSettings.Password};";

            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            using var sqlCommand = new NpgsqlCommand();
            sqlCommand.Connection= sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $"DROP TABLE IF EXISTS {tableTittle}";
            await sqlCommand.ExecuteNonQueryAsync();
            string textCmd = $"UPDATE \"{tableTittle}\" " +
                             $"SET \"{columnTittle}\" = \'{newValue}\' " +
                             $"WHERE \"Id\" = \'{id}\';";
            sqlCommand.CommandText = textCmd;
            await sqlCommand.ExecuteNonQueryAsync();

            sqlConnection.Close();
        }


        public async Task AddRecord(DBSettings dbSettings, string tableTittle, WarehouseProduct warehouseProduct)
        {
            if(warehouseProduct is null)
            {
                return;
            }
            if (warehouseProduct.Tittle is null)
            {
                return;
            }
            if (warehouseProduct.Property is null)
            {
                return;
            }
            if (warehouseProduct.Size is null)
            {
                return;
            }
            if (warehouseProduct.ExpirationDate is null)
            {
                return;
            }
            if (warehouseProduct.Location is null)
            {
                return;
            }
            if (warehouseProduct.PurchaseCost is null)
            {
                return;
            }
            if (warehouseProduct.OrderNumber is null)
            {
                return;
            }
            if (warehouseProduct.ReceiptDate is null)
            {
                return;
            }
            if (warehouseProduct.Note is null)
            {
                return;
            }

            string connectionString = $"Server={dbSettings.Server}; " +
                                      $"Port={dbSettings.Port}; " +
                                      $"DataBase={dbSettings.Name}; " +
                                      $"User Id={dbSettings.UserId}; " +
                                      $"Password={dbSettings.Password};";

            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            using var sqlCommand = new NpgsqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $"DROP TABLE IF EXISTS {tableTittle}";
            await sqlCommand.ExecuteNonQueryAsync();
            string textCmd = $"INSERT INTO \"tableTittle\" (\"wp_Tittle\", \"wp_Property\", \"wp_Size\", \"wp_ExpirationDate\", \"wp_Location\", \"wp_PurchaseCost\", \"wp_OrderNumber\", \"wp_ReceiptDate\", \"wp_Note\") " +
                             $"VALUES (@tittle, @property, @size, @expirationDate, @Location, @purchaseCost, @orderNumber, @receiptDate, @note)" +
                             $"returning \"wp_Id\"";
            await using (var cmd = new NpgsqlCommand(textCmd, sqlConnection))
            {
                cmd.Parameters.AddWithValue("wp_Tittle", warehouseProduct.Tittle);
                cmd.Parameters.AddWithValue("wp_Property", warehouseProduct.Property);
                cmd.Parameters.AddWithValue("wp_Size", warehouseProduct.Size);
                cmd.Parameters.AddWithValue("wp_ExpirationDate", warehouseProduct.ExpirationDate);
                cmd.Parameters.AddWithValue("wp_Location", warehouseProduct.Location);
                cmd.Parameters.AddWithValue("wp_PurchaseCost", warehouseProduct.PurchaseCost);
                cmd.Parameters.AddWithValue("wp_OrderNumber", warehouseProduct.OrderNumber);
                cmd.Parameters.AddWithValue("wp_ReceiptDate", warehouseProduct.ReceiptDate);
                cmd.Parameters.AddWithValue("wp_Note", warehouseProduct.Note);

                await cmd.ExecuteNonQueryAsync();
            }


            sqlConnection.Close();
        }


    }
}