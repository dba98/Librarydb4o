using System;

namespace Librarydb4o.Models
{
    public class SerialItem : Item
    {
        #region Attributes

        private uint _number;
        private uint _volume;
        private DateTime _date;
        private Serial _serial;
        
        #endregion
        
        #region Properties

        public uint Number => _number;
        public uint Volume => _volume;
        public DateTime Date => _date;
        public Serial Serial => _serial;

        #endregion

        public SerialItem()
        {
            
        }
    }
}