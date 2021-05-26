using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Organization : Subject
    {
        public Organization(List<Monograph> monographs) : base(monographs)
        {
            
        }
    }
}