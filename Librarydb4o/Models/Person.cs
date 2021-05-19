﻿using System.Collections.Generic;

namespace Librarydb4o.Models
{
    public class Person : Subject
    {
        #region Attributes

        private Account _account;
        private Serial _serial;
        
        #endregion

        #region Properties

        public Account Account => _account;
        public Serial Serial => _serial;

        #endregion

        public Person()
        {
            
        }

    }
}