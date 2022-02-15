using Car_Rental.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Car_Rental.views.carview
{
    /// <summary>
    /// Interaction logic for CarView.xaml
    /// </summary>
    public partial class CarView : UserControl
    {
        private ObservableCollection<Car> Cars;

        public CarView()
        {
            InitializeComponent();

            Cars = new ObservableCollection<Car>();

            carGrid.ItemsSource = Cars;
        }

        public void AddCustomer()
        {
            // Create your new customer instance
            Car customer = new Car
            {
                Manufacturer = ManufacturerBox.Text,
                Model = ModelBox.Text,
            };

            Cars.Add(customer);

            return;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer();
        }

        private void DeleteCar()
        {
            if (Cars.Count <= 0) return;

            if (carGrid.SelectedIndex > Cars.Count || carGrid.SelectedIndex < 0) return;

            try
            {
                Cars.RemoveAt(carGrid.SelectedIndex);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteCar();
        }
    }
}