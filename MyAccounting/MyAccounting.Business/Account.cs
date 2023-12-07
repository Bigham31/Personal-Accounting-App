using MyAccounting.DataLayer.Context;
using MyAccounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Business
{
    public class Account
    {
        public static ReportChart LineChart()
        {
            ReportChart rc = new ReportChart();
            using (AccountingContext db = new AccountingContext())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var income = db.TransactionRepository.Get(c => c.TypeID == 1 && c.DateTime >= startDate && c.DateTime <= endDate).Select(c => c.Amount).ToList();
                var expenses = db.TransactionRepository.Get(c => c.TypeID == 2 && c.DateTime >= startDate && c.DateTime <= endDate).Select(c => c.Amount).ToList();

                rc.Income = income.Sum();
                rc.Expenses = expenses.Sum();
                rc.Balance = (income.Sum() - expenses.Sum());
            }
            return rc;
        }
    }
}
