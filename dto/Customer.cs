using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Car_Rental.dto
{
    public class Customer : INotifyPropertyChanged
    {
        private string mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
                NotifyPropertyChanged();
            }
        }

        private DateTime mBirthdate;

        public DateTime Birthdate
        {
            get
            {
                return mBirthdate;
            }
            set
            {
                mBirthdate = value;
                NotifyPropertyChanged();
            }
        }

        private string mAddress;

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string mPhone;

        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
                NotifyPropertyChanged();
            }
        }

        private bool mIsActive;

        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
                NotifyPropertyChanged();
            }
        }

        public Customer()
        {
            Name = String.Empty;
            Birthdate = DateTime.MinValue;
            Address = String.Empty;
            Phone = String.Empty;
            IsActive = false;
        }

        public Customer(string name, bool isActive, DateTime birthdate, string address, string phone)
        {
            Name = name;
            Birthdate = birthdate;
            Address = address;
            Phone = phone;
            IsActive = isActive;
        }

        public Customer(string name, DateTime birthdate, string address, string phone, bool isActive)
        {
            Name = name;
            Birthdate = birthdate;
            Address = address;
            Phone = phone;
            IsActive = isActive;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}