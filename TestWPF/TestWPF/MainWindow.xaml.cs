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

namespace TestWPF
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

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            messageLabel.Content = "Gone Fishing.";
        }

        private void SignOut_Button_Click(object sender, RoutedEventArgs e)
        {
            messageLabel.Content = "Back From Fishing. Making Fish Tacos.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newLabel.Content = "Click on the Click here button";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            newLabel.Content = "Click on the Juniorless red button";
        }
    } aslkfja;slkf
}