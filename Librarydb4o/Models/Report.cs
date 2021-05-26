using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Report : Monograph
    {
        public Report(uint numberOfPages,List<Copy> copies) : base(numberOfPages,copies)
        {
        }
    }
}