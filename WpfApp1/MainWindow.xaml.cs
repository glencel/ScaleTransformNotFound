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

namespace WpfApp1
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

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            TextBox.Visibility = Visibility.Visible;

            // My workarounds:
            // 1: Delay focus
            // await Task.Delay(111); works for me but not reliable especially on slower machines.
            // 2: Try until successful
            // try
            // {
            //     TextBox.Focus();
            // }
            // catch (Exception){}

            TextBox.Focus();
        }
    }
}
