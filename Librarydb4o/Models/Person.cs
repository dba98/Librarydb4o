using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Person : Subject
    {
        #region Attributes

        private string _name;
        private Account _account;
        private Serial _serial;
        
        #endregion

        #region Properties

        public string Name => _name;
        public Account Account
        {
            get => _account;
            set => _account = value;
        }

        public Serial Serial => _serial;

        #endregion

        public Person(string name,Account account,Serial serial,List<Monograph> monographs) : base(monographs)
        {
            _name = name;
            _account = account;
            _serial = serial;
        }

    }
}