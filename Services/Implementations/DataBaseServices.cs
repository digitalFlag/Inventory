using Inventory.Models;
using Inventory.Resources.Constants;
using Npgsql;
using System.Data;

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
            NpgsqlCommand sqlCommand = new()
            {
                Connection = sqlConnection,
                CommandType = System.Data.CommandType.Text,
                CommandText = $"SELECT * FROM \"{tableTittle}\""
            };
            NpgsqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                loadedData.Load(sqlDataReader);
            }
            sqlCommand.Dispose();
            sqlConnection.Close();
            return loadedData;
        }

        //Update Record In Table From Data Base
        public async Task UpdateRecord(DBSettings dbSettings, string tableTittle, string columnTittle, string columnId,string idValue, string newValue)
        {
            string connectionString = $"Server={dbSettings.Server}; " +
                                      $"Port={dbSettings.Port}; " +
                                      $"DataBase={dbSettings.Name}; " +
                                      $"User Id={dbSettings.UserId}; " +
                                      $"Password={dbSettings.Password};";

            var sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();

            using NpgsqlCommand sqlCommand = new()
            {
                Connection = sqlConnection,
                CommandType = System.Data.CommandType.Text,
                CommandText = $"DROP TABLE IF EXISTS {tableTittle}",
            };
            await sqlCommand.ExecuteNonQueryAsync();

            string textCmd = $"UPDATE \"{tableTittle}\" " +
                             $"SET \"{columnTittle}\" = \'{newValue}\' " +
                             $"WHERE \"{columnId}\" = \'{idValue}\'";

            sqlCommand.CommandText = textCmd;
            await sqlCommand.ExecuteNonQueryAsync();

            sqlConnection.Close();
        }
        
        //Add New Record To Warehouse Table
        public async Task AddWarehouseProduct(DBSettings dbSettings, string tableTittle, WarehouseProduct warehouseProduct)
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

            using NpgsqlCommand sqlCommand = new()
            {
                Connection = sqlConnection,
                CommandType = System.Data.CommandType.Text,
                CommandText = $"DROP TABLE IF EXISTS {tableTittle}",
            };

            await sqlCommand.ExecuteNonQueryAsync();

            string textCmd = $"INSERT INTO \"{tableTittle}\" (\"wp_Tittle\", \"wp_Property\", \"wp_Size\", \"wp_ExpirationDate\", \"wp_Location\", \"wp_PurchaseCost\", \"wp_OrderNumber\", \"wp_ReceiptDate\", \"wp_Note\") " +
                             $"VALUES (\'{warehouseProduct.Tittle}\', \'{warehouseProduct.Property}\', \'{warehouseProduct.Size}\', \'{warehouseProduct.ExpirationDate}\', \'{warehouseProduct.Location}\', \'{warehouseProduct.PurchaseCost}\', \'{warehouseProduct.OrderNumber}\', \'{warehouseProduct.ReceiptDate}\', \'{warehouseProduct.Note}\')";

            //string textCmd = $"INSERT INTO \"{tableTittle}\" (\"{DbTableSoldProducts.propertyTittle}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyTittle}\", " +
            //                                                $" \"{DbTableWarehouseProducts.propertySize}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyExpirationDate}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyLocation}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyPurchaseCost}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyOrderNumber}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyReceiptDate}\", " +
            //                                                $"\"{DbTableWarehouseProducts.propertyNote}\") " +
            //                                        $"VALUES (\'{warehouseProduct.Tittle}\', " +
            //                                                $"\'{warehouseProduct.Property}\', " +
            //                                                $"\'{warehouseProduct.Size}\', " +
            //                                                $"\'{warehouseProduct.ExpirationDate}\', " +
            //                                                $"\'{warehouseProduct.Location}\', " +
            //                                                $"\'{warehouseProduct.PurchaseCost}\', " +
            //                                                $"\'{warehouseProduct.OrderNumber}\', " +
            //                                                $"\'{warehouseProduct.ReceiptDate}\', " +
            //                                                $"\'{warehouseProduct.Note}\')";
            sqlCommand.CommandText = textCmd;

            await sqlCommand.ExecuteNonQueryAsync();

            sqlConnection.Close();
        }

        //Add New Record To SoldProducts Table
        public async Task AddSoldProduct(DBSettings dbSettings, string tableTittle, SoldProduct soldProduct)
        {
            if (soldProduct is null)
            {
                return;
            }
            if (soldProduct.Tittle is null)
            {
                return;
            }
            if (soldProduct.Property is null)
            {
                return;
            }
            if (soldProduct.Size is null)
            {
                return;
            }
            if (soldProduct.ExpirationDate is null)
            {
                return;
            }
            if (soldProduct.PurchaseCost is null)
            {
                return;
            }
            if (soldProduct.SoldCost is null)
            {
                return;
            }
            if (soldProduct.OrderNumber is null)
            {
                return;
            }
            if (soldProduct.ReceiptDate is null)
            {
                return;
            }
            if (soldProduct.SoldDate is null)
            {
                return;
            }
            if (soldProduct.Note is null)
            {
                return;
            }
            if (soldProduct.CustomerId is null)
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
            string textCmd = $"INSERT INTO \"{tableTittle}\" (\"{DbTableSoldProducts.propertyTittle}\", " +
                                                            $"\"{DbTableSoldProducts.propertyProperty}\", " +
                                                            $"\"{DbTableSoldProducts.propertySize}\", " +
                                                            $"\"{DbTableSoldProducts.propertyExpirationDate}\", " +
                                                            $"\"{DbTableSoldProducts.propertyPurchaseCost}\", " +
                                                            $"\"{DbTableSoldProducts.propertySoldCost}\", " +
                                                            $"\"{DbTableSoldProducts.propertyOrderNumber}\", " +
                                                            $"\"{DbTableSoldProducts.propertyReceiptDate}\", " +
                                                            $"\"{DbTableSoldProducts.propertySoldDate}\", " +
                                                            $"\"{DbTableSoldProducts.propertyNote}\", " +
                                                            $"\"{DbTableSoldProducts.propertyCustomerId}\") " +
                                                    $"VALUES (\'{soldProduct.Tittle}\', " +
                                                            $"\'{soldProduct.Property}\', " +
                                                            $"\'{soldProduct.Size}\', " +
                                                            $"\'{soldProduct.ExpirationDate}\', " +
                                                            $"\'{soldProduct.PurchaseCost}\', " +
                                                            $"\'{soldProduct.SoldCost}\', " +
                                                            $"\'{soldProduct.OrderNumber}\', " +
                                                            $"\'{soldProduct.ReceiptDate}\', " +
                                                            $"\'{soldProduct.SoldDate}\', " +
                                                            $"\'{soldProduct.Note}\', " +
                                                            $"\'{soldProduct.CustomerId}\')";

            sqlCommand.CommandText = textCmd;
            await sqlCommand.ExecuteNonQueryAsync();

            sqlConnection.Close();
        }

        //Delete Record From A Data Base
        public async Task DeleteRecord(DBSettings dbSettings, string tableTittle, string featureName, string featureValue)
        {
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
            string textCmd = $"DELETE FROM \"{tableTittle}\" WHERE \"{featureName}\" IN ({featureValue})";
            sqlCommand.CommandText = textCmd;
            await sqlCommand.ExecuteNonQueryAsync();

            sqlConnection.Close();
        }
    }
}