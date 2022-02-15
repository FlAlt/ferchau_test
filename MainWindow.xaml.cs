using System.Windows;

namespace Car_Rental
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

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            carview.Visibility = Visibility.Collapsed;
            customerview.Visibility = Visibility.Visible;
        }

        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            carview.Visibility = Visibility.Visible;
            customerview.Visibility = Visibility.Collapsed;
        }
    }
}