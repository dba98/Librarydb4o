using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Dissertation : AcademicMonograph
    {
        public Dissertation(uint numberOfPages,List<Copy> copies) : base(numberOfPages,copies)
        {
            
        }
    }
}