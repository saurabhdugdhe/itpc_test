using DisplayData.ViewModel;
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

namespace DisplayData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWindowManager
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.WindowManager = this;
            DataContext = mainWindowViewModel;
            
        }

        public void CloseWindow()
        {
            this.Close();
        }

        public Window GetWindow()
        {
            return this;
        }

        private void mydatagrid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
