using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAccounting.DataLayer.Repositories;
using MyAccounting.DataLayer.Services;

namespace MyAccounting.DataLayer.Context
{
    public class AccountingContext : IDisposable
    {
        //Instantiation of the connection string
        MyAccountingDBEntities db = new MyAccountingDBEntities();

        // Private field to hold the data repository for Contacts
        private IDataRepository<Contacts> _contactRepository;

        // Public property for accessing the ContactRepository
        public IDataRepository<Contacts> ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                {
                    _contactRepository = new IDataRepository<Contacts>(db);
                }
                return _contactRepository;
            }
        }
        // Private field to hold the data repository for Transactions
        private IDataRepository<Transactions> _transactionRepository;

        // Public property for accessing the TransactionRepository
        public IDataRepository<Transactions> TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new IDataRepository<Transactions>(db);
                }
                return _transactionRepository;
            }
        }

        //Private field to hold the data repository for ContactViewModel
        private ITransactionRepository _viewModelRepository;

        //Public property for accessing the ViewModelRepository
        public ITransactionRepository ViewModelRepository
        {
            get
            {
                if (_viewModelRepository == null)
                {
                    _viewModelRepository = new IcontactRepository(db);

                }
                return _viewModelRepository;
            }
        }


        //Private field to hold the data repository for Login
        private IDataRepository<Login> _loginRepository;

        //Public property for accessing the Login
        public IDataRepository<Login> LoginRepository
        {
            get
            {
                if(_loginRepository == null)
                {
                    _loginRepository = new IDataRepository<Login>(db);
                }
                return _loginRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
