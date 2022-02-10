using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            //звязування з ViewModels
            WpfDate.ViewModels.MainViewModels studentViewModelObject =
               new WpfDate.ViewModels.MainViewModels();
            studentViewModelObject.LoadInformation();

            //можливе отримення значенння дати з DatePicker
            DateTime? selectedDate = datePicker.SelectedDate;
            if (selectedDate.HasValue)
            {
                string formatted = selectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            // StudentViewControl.DataContext = studentViewModelObject;
        }

        //метод отримання повідомлення, вітання з дн
        private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
        {
            //<Button Name="btnSimpleMessageBox" Click="btnSimpleMessageBox_Click">Simple MessageBox</Button>
            MessageBox.Show("З днем народження, любий друже!");
        }

 
    }
}
