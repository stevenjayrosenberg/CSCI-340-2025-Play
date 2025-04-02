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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class TestPage1 : Window
    {
        public TestPage1()
        {
            InitializeComponent();
        }

        private void Button_Click_home(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Height = this.Height;
            homepage.Width = this.Width;
            homepage.Top = this.Top;
            homepage.Left = this.Left;
            homepage.Show();
            this.Close();
        }
    }
}
