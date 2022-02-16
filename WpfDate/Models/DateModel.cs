using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfDate.Models
{
    public class DateModel
    {
        private DateTime _birthday;
        //DateModel(DateTime birthday)
        //{
        //    this._birthday = birthday;
        //}

        public DateTime Birthday
        {
            get
            { return _birthday; }

            set
            {
                if (_birthday != value)
                {
                    _birthday = value;
                }
            }
        }
    }
}
