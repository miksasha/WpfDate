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

        private void OnMouseEnter(MouseEventArgs e)
        {

        }
    }
}
