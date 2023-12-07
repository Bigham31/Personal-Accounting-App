using MyAccounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.DataLayer.Repositories
{
    public interface ITransactionRepository
    {
        List<ListContactViewModel> GetContactNames(string fillter = "");
        int GetContactidByName(string name);
        string GetContactNameByid(int contactid);
    }
}
