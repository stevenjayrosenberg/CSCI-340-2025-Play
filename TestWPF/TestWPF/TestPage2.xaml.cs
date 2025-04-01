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
using System.Windows.Shapes;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for TestPage2.xaml
    /// </summary>
    public partial class TestPage2 : Window
    {
        public TestPage2()
        {
            InitializeComponent();
        }
        private void Button_Click_home(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Close();
        }
    }
}
