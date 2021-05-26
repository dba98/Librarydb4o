using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Thesis : AcademicMonograph
    {
        public Thesis(uint numberOfPages,List<Copy> copies) : base(numberOfPages, copies)
        {
            
        }
    }
}