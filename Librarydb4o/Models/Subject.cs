using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Subject
    {

        #region Attributes

        private List<Monograph> _monographs;

        #endregion

        #region Properties

        public List<Monograph> Monographs => _monographs;

        #endregion
        
        public Subject(List<Monograph> monographs)
        {
            _monographs = monographs;
        }
    }
}