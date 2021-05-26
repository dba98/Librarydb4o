using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Item
    {
        private List<Copy> _copies;

        public Item(List<Copy> copies)
        {
            _copies = copies;
        }
    }
}