using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Book : Monograph
    {
        #region Attributes

        private string _isbn;

        #endregion

        #region Properties

        public string Isbn => _isbn;

        #endregion

        public Book(string isbn,uint numberOfPages,List<Copy> copies) : base(numberOfPages,copies)
        {
            _isbn = isbn;
        }
    }
}