using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDate.ViewModels;

namespace WpfDate.Views
{
    /// <summary>
    /// Логика взаимодействия для DateUserControl.xaml
    /// </summary>
    public partial class DateUserControl : UserControl
    {
        private MainViewModels _viewModel;

        public DateUserControl()
        {
            InitializeComponent();
            DataContext = _viewModel = new MainViewModels();

        }

        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Birthday = (DateTime)DatePicker.SelectedDate;

            if (!_viewModel.CorrectDate())
            {
                MessageBox.Show("Ви ввели не правильну дату дня народження!");
                if(_viewModel.Age > 135)
                {
                    Age.Text = "Вік: " + _viewModel.Age + ". Перевірте введений рік.";
                }
                else
                {
                    Age.Text = "Людина ще не народилась";
                }
                WesternAstrologicalSystem.Text = "Західна астрологічна системи: " + _viewModel.WSign;
                ChinaAstrologicalSystem.Text = "Китайська астрологічна системи: " + _viewModel.CSign;
            }
            else
            {
                Age.Text = "Вік: " + _viewModel.Age;
                if(_viewModel.BirthdayIsToday())
                {
                    MessageBox.Show("Вітаємо з Днем народження!\nБудьте щасливі!");
                }
                WesternAstrologicalSystem.Text = "Західна астрологічна системи: " + _viewModel.WSign;
                ChinaAstrologicalSystem.Text = "Китайська астрологічна системи: " + _viewModel.CSign;
            }
        }
    }
}
