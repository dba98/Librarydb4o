namespace Librarydb4o.Models
{
    public class Monograph : Item
    {
        #region Attributes

        private uint _numberOfPages;

        #endregion

        #region Properties

        public uint NumberOfPages => _numberOfPages;

        #endregion

        public Monograph()
        {
            
        }
    }
}