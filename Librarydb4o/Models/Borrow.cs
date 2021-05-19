using System;

namespace Librarydb4o.Models
{
    public class Borrow
    {
        #region Attributes

        private DateTime _borrowedDate;
        private DateTime _returnedDate;
        private Copy _copyBorrowed;
        private Account _accountReq;
        
        #endregion
        
        #region Properties

        public DateTime BorrowedDate => _borrowedDate;
        public DateTime ReturnedDate => _returnedDate;
        public Copy CopyBorrowed => _copyBorrowed;
        public Account AccountReq => _accountReq;
        
        #endregion

        public Borrow()
        {
            
        }
    }
}