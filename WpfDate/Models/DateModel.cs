using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfDate.Models
{
    public class DateModel
    {
        private DateTime _birthday = DateTime.Today;
        private int _age = 0;
       
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

        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                _age = today.Year - _birthday.Year;
                if (today.Month - _birthday.Month < 0) return --_age;
                if (today.Month - _birthday.Month == 0) 
                    if(today.Day - _birthday.Day < 0) return --_age;
                return _age;
            }
            set {  _age = value; }
        }

        public bool CorrectDate()
        {
            if (_birthday > DateTime.Today) return false;
            if(_age > 135) return false;
            return true;
        }

        public bool BirthdayIsToday()
        {
            if (_birthday == DateTime.Today) return true;
            return false;
        }

        public string WSign()
        {
            switch (_birthday.Month)
            {
                case 1:
                    if (_birthday.Day >= 21) 
                    {
                        return "Водолій";
                    }else
                    {
                        return "Козоріг";
                    }
                case 2:
                    if (_birthday.Day >= 20)
                    {
                        return "Риби";
                    }
                    else
                    {
                        return "Водолій";
                    }
                case 3:
                    if (_birthday.Day >= 21)
                    {
                        return "Овен";
                    }
                    else
                    {
                        return "Риби";
                    }
                case 4:
                    if (_birthday.Day >= 21)
                    {
                        return "Телець";
                    }
                    else
                    {
                        return "Овен";
                    }
                case 5:
                    if (_birthday.Day >= 22)
                    {
                        return "Близнята";
                    }
                    else
                    {
                        return "Телець";
                    }
                case 6:
                    if (_birthday.Day >= 22)
                    {
                        return "Рак";
                    }
                    else
                    {
                        return "Близнята";
                    }
                case 7:
                    if (_birthday.Day >= 23)
                    {
                        return "Лев";
                    }
                    else
                    {
                        return "Рак";
                    }
                case 8:
                    if (_birthday.Day >= 22)
                    {
                        return "Діва";
                    }
                    else
                    {
                        return "Лев";
                    }
                case 9:
                    if (_birthday.Day >= 24)
                    {
                        return "Терези";
                    }
                    else
                    {
                        return "Діва";
                    }
                case 10:
                    if (_birthday.Day >= 24)
                    {
                        return "Скорпіон";
                    }
                    else
                    {
                        return "Терези";
                    }
                case 11:
                    return _birthday.Day >= 24 ? "Стрілець" : "Скорпіон";
                case 12:
                    return _birthday.Day >= 23 ? "Козоріг" : "Стрілець";
                default:
                    break;
            }
            return "Wrong date";
        }
        public string CSign()
        {
            if ((_birthday.Year - 4) % 12 == 0) { return "Щур"; }
            if ((_birthday.Year - 5) % 12 == 0) { return "Бик"; }
            if ((_birthday.Year - 6) % 12 == 0) { return "Тигр";}
            if ((_birthday.Year - 7) % 12 == 0) { return "Кролик"; }
            if ((_birthday.Year - 8) % 12 == 0) { return "Дракон"; }
            if ((_birthday.Year - 9) % 12 == 0) { return "Змія"; }
            if ((_birthday.Year - 10) % 12 == 0) { return "Кінь"; }
            if ((_birthday.Year - 11) % 12 == 0) { return "Коза"; }
            if ((_birthday.Year - 12) % 12 == 0) { return "Мавпа"; }
            if ((_birthday.Year - 1) % 12 == 0) { return "Півень"; }
            if ((_birthday.Year - 2) % 12 == 0) { return "Собака"; }
            if ((_birthday.Year - 3) % 12 == 0) { return "Свиня"; }
            return "Wrong date";
        }
    }
}
