using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Serial
    {
        #region Attributes

        private List<SerialItem> _serialItem;
        private string _title;
        
        #endregion

        #region Properties

        public List<SerialItem> SerialItem => _serialItem;
        public string Title => _title;

        #endregion

        public Serial()
        {
            
        }
    }
}