using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Monograph : Item
    {
        #region Attributes

        private uint _numberOfPages;

        #endregion

        #region Properties

        public uint NumberOfPages => _numberOfPages;

        #endregion

        public Monograph(uint numberOfPages,List<Copy> copies) : base(copies)
        {
            _numberOfPages = numberOfPages;
        }
    }
}