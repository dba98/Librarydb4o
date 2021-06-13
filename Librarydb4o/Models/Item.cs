using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Item
    {
        #region Fields

        private List<Copy> _copies;

        #endregion

        #region Constructor

        public Item(List<Copy> copies)
        {
            _copies = copies;
        }

        #endregion

        #region Properties

        public List<Copy> Copies { get; set; }

        #endregion
    }
}