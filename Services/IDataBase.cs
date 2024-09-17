using Inventory.Models;
using System.Data;

namespace Inventory.Services
{
    public interface IDataBase
    {

        public DataTable GetData(DBSettings dbSettings, string tableTittle);

        public Task UpdateRecord(DBSettings dbSettings, string tableTittle, string columnTittle, string columnId, string idValue, string newValue);

        public Task AddWarehouseProduct(DBSettings dbSettings, string tableTittle, WarehouseProduct warehouseProduct);

        public Task AddSoldProduct(DBSettings dbSettings, string tableTittle, SoldProduct soldProduct);

        public Task DeleteRecord(DBSettings dbSettings, string tableTittle, string featureName, string featureValue);


    }
}
