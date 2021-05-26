using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class AcademicMonograph : Monograph
    {
        public AcademicMonograph(uint numberOfPages,List<Copy> copies) : base(numberOfPages,copies)
        {
            
        }
    }
}