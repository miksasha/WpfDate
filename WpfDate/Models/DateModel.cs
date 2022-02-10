using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfDate.Models
{
    public class DateModel
    {

    }
    public class Date : INotifyPropertyChanged
    {
        private DateTime birthday;
        Date(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public DateTime FirstName
        {
            get
            {
                return birthday;
            }

            set
            {
                if (birthday != value)
                {
                    birthday = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
