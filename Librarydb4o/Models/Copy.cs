using System;
using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Copy
    {
        #region Attributes

        private DateTime _acquiredDate;
        private Item _item;
        private List<Borrow> _borrows;
        private string _callNumber;
        private string _location;
        
        #endregion

        #region Properties

        public DateTime AcquiredDate => _acquiredDate;
        public Item Item => _item;
        public List<Borrow> Borrows => _borrows;
        public string CallNumber => _callNumber;
        public string Location => _location;

        #endregion
        
        public Copy()
        {
            
        }
    }
}