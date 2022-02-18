using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WpfDate.Models
{
    public class DateModel
    {
        private DateTime _birthday = new DateTime(2022, 2, 22);
        private TimeSpan _age = new TimeSpan();
           private enum ChinaSystem { Пацюк, Бик, Тигр, Кролик, Дракон, Змія, Кінь, Вівця, Мавпа, Півень, Собака, Свиня };

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

        public TimeSpan Age
        {
            get
            {
                DateTime today = DateTime.Today;
                _age = today.Subtract(Birthday);
                return _age;
            }
        }

        //WesternSystem { Овен, Телець, Близнюки, Рак, Лев, Діва, Терези, Скорпіон, Стрілець, Козеріг, Водолій, Риби };

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
