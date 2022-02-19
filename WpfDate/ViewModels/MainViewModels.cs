using System;
using System.ComponentModel;
using System.Windows;
using WpfDate.Models;

namespace WpfDate.ViewModels
{
    public class MainViewModels : INotifyPropertyChanged
    {
        #region Fields
        private DateModel _date = new DateModel();
        private RelayCommand<object> _selectDateCommand;
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
        public bool CorrectDate()
        {
            return _date.CorrectDate();
        }

        public bool BirthdayIsToday()
        {
            return _date.BirthdayIsToday();
        }

        public string Age
        {
            get
            {
                if (_date.Age < 0)
                {
                    return "Людина ще не народилась";
                }
                return _date.Age.ToString();
            }
            set { _= _date.Age; }
        }
        public string WSign
        {
            get { return _date.WSign(); }
            set { _ = _date.WSign(); }
        }
        public string CSign
        {
            get { return _date.CSign(); }
            set { _ = _date.CSign(); }
        }
        #endregion

        public RelayCommand<object> SelectDateCommand
        {
            get
            {
                return _selectDateCommand ??= new RelayCommand<object>(_ => SetData());
            }
        }
        private void SetData()
        {
            if (!_date.CorrectDate())
            {
                NotifyPropertyChanged("Age");
                NotifyPropertyChanged("WSign");
                NotifyPropertyChanged("CSign");
                MessageBox.Show("Ви ввели не правильну дату народження!");
            }
            else
            {

                NotifyPropertyChanged("Age");
                NotifyPropertyChanged("WSign");
                NotifyPropertyChanged("CSign");
                if (_date.BirthdayIsToday())
                {
                    MessageBox.Show("Вітаємо з Днем народження!\nБудьте щасливі!");
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }


    }
}
