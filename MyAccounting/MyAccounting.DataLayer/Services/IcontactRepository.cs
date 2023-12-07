using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.DataLayer;
using MyAccounting.DataLayer.Repositories;
using MyAccounting.ViewModel;

namespace MyAccounting.DataLayer.Services
{
    public class IcontactRepository : ITransactionRepository
    {
        private MyAccountingDBEntities _db;
        public IcontactRepository(MyAccountingDBEntities db)
        {
            _db = db;
        }

        public int GetContactidByName(string name)
        {
            return _db.Contacts.First(c => c.FullName == name).ContactID;
        }

        public string GetContactNameByid(int contactid)
        {
            return _db.Contacts.First(c => c.ContactID == contactid).FullName;
        }

        public List<ListContactViewModel> GetContactNames(string fillter = "")
        {
            if(fillter == "")
            {
                return _db.Contacts.Select(c => new ListContactViewModel()
                {
                    ContactID = c.ContactID,
                    FullName = c.FullName
                }).ToList();
            }
            else
            {
                return _db.Contacts.Where(c => c.FullName.Contains(fillter)).Select(c => new ListContactViewModel()
                {
                    ContactID = c.ContactID,
                    FullName = c.FullName
                }).ToList();
            }
        }
    }
}
