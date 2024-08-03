using Inventory.Models;
using System.Data;

namespace Inventory.Services
{
    public interface IDataBase
    {

        public DataTable GetData(DBSettings dbSettings, string tableTittle);

        public Task UpdateRecord(DBSettings dbSettings, string tableTittle, string columnTittle, string columnId, string idValue, string newValue);

        public Task AddRecord(DBSettings dbSettings, string tableTittle, WarehouseProduct warehouseProduct);

    }
}
