using System;
using System.Collections.Generic;
using System.Text;
using WpfDate.Models;

namespace WpfDate.ViewModels
{
    public class MainViewModels
    {
        #region Fields
        private DateModel _date = new DateModel();
        #endregion

        #region Properties
        public DateTime Birthday
        {
            get
            { return _date.Birthday; }

            set
            {
                if (_date.Birthday != value)
                {
                    _date.Birthday = value;
                }
            }
        }

        public TimeSpan Age
        {
            get
            {
                return _date.Age;
            }
        }
        public string WSign
        {
            get
            { return _date.WSign(); }
        }
        public string CSign
        {
            get
            { return _date.CSign(); }
        }
        #endregion



    }
}
