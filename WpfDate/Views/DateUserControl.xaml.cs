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

    }
}
