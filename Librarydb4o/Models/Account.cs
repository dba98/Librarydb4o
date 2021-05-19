using System;
using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Account
    {
        #region Attributes
        
        private DateTime _dateOpened;
        private bool _isValid;
        private AccountType _accountType;
        private Person _owner;
        private List<Borrow> _borrows;
        
        #endregion

        #region Properties

        public DateTime DateOpened => _dateOpened;
        public bool IsValid => _isValid;
        public AccountType AccountType => _accountType;
        public Person Owner => _owner;
        public List<Borrow> Borrows => _borrows;
        
        #endregion

        public Account()
        {
            
        }
    }
}