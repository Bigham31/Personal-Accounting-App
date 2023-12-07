using MyAccounting.DataLayer.Context;
using MyAccounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Business
{
    public class PieChartAccount
    {
        public static List<PieChart> chart()
        {
            using (AccountingContext db = new AccountingContext())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                return db.TransactionRepository.Get(c => c.TypeID == 2 && c.DateTime >= startDate && c.DateTime <= endDate).Select(c => new PieChart { Amount = c.Amount , Description = c.Discription} ).ToList();
            }
        }
    }
}
