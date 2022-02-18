using System;
using System.Windows;
using System.Windows.Controls;
using WpfDate.ViewModels;

namespace WpfDate.Views
{
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
            _viewModel.Birthday = (DateTime)BirthdayPicker.SelectedDate;

            if (!_viewModel.CorrectDate())
            {
                MessageBox.Show("Ви ввели не правильну дату дня народження!");
                if(_viewModel.Age > 135)
                {
                    TbAge.Text = "Вік: " + _viewModel.Age + ". Перевірте введений рік.";
                }
                else
                {
                    TbAge.Text = "Людина ще не народилась";
                }
                TbWesternAstrologicalSystem.Text = "Західна астрологічна системи: " + _viewModel.WSign;
                TbChinaAstrologicalSystem.Text = "Китайська астрологічна системи: " + _viewModel.CSign;
            }
            else
            {
                TbAge.Text = "Вік: " + _viewModel.Age;
                if(_viewModel.BirthdayIsToday())
                {
                    MessageBox.Show("Вітаємо з Днем народження!\nБудьте щасливі!");
                }
                TbWesternAstrologicalSystem.Text = "Західна астрологічна системи: " + _viewModel.WSign;
                TbChinaAstrologicalSystem.Text = "Китайська астрологічна системи: " + _viewModel.CSign;
            }
        }
    }
}
