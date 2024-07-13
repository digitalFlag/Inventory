using Inventory.Models;
using System.Data;

namespace Inventory.Services
{
    public interface IDataBase
    {

        public DataTable GetData(DBSettings dbSettings, string tableTittle);



        
    }
}
