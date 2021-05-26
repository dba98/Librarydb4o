using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Serial
    {
        #region Attributes

        private List<SerialItem> _serialItems;
        private string _title;
        
        #endregion

        #region Properties

        public List<SerialItem> SerialItem => _serialItems;
        public string Title => _title;

        #endregion

        public Serial(List<SerialItem> serialItems,string title)
        {
            _serialItems = serialItems;
            _title = title;
        }
    }
}