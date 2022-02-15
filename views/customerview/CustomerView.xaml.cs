using Car_Rental.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Car_Rental.views.customerview
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl, INotifyPropertyChanged
    {
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; NotifyPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ObservableCollection<Customer> Customers;

        public CustomerView()
        {
            InitializeComponent();
            Customers = new ObservableCollection<Customer>();
            customerGrid.ItemsSource = Customers;
        }

        public void AddCustomer()
        {
            // Create your new customer instance
            Customer customer = new Customer
            {
                Name = NameBox.Text,
                Phone = PhoneBox.Text,
                IsActive = true,
                Address = AddressBox.Text,
                Birthdate = DateTime.Parse(BirthdateBox.Text),
            };

            Customers.Add(customer);

            return;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer();
        }

        private void DeleteCustomer()
        {
            if (Customers.Count <= 0) return;

            if (customerGrid.SelectedIndex > Customers.Count || customerGrid.SelectedIndex < 0) return;

            try
            {
                Customers.RemoveAt(customerGrid.SelectedIndex);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteCustomer();
        }
    }

    public class CustomDatePicker : DatePicker
    {
        protected DatePickerTextBox _datePickerTextBox;
        protected readonly string _shortDatePattern;

        public CustomDatePicker()
            : base()
        {
            _shortDatePattern = Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _datePickerTextBox = this.Template.FindName("PART_TextBox", this) as DatePickerTextBox;
            if (_datePickerTextBox != null)
            {
                _datePickerTextBox.TextChanged += dptb_TextChanged;
            }
        }

        private void dptb_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime dt;
            if (DateTime.TryParseExact(_datePickerTextBox.Text, _shortDatePattern, Thread.CurrentThread.CurrentCulture,
                System.Globalization.DateTimeStyles.None, out dt))
            {
                this.SelectedDate = dt;
            }
        }
    }
}