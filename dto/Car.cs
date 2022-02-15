using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Car_Rental.dto
{
    public class Car : INotifyPropertyChanged
    {
        private string mManufacturer;

        public string Manufacturer
        {
            get { return mManufacturer; }
            set
            {
                mManufacturer = value;
                NotifyPropertyChanged();
            }
        }

        private string mModel;

        public string Model
        {
            get { return mModel; }
            set
            {
                mModel = value;
                NotifyPropertyChanged();
            }
        }

        private float mPricePerDay;

        public float PricePerDay
        {
            get { return mPricePerDay; }
            set
            {
                mPricePerDay = value;
                NotifyPropertyChanged();
            }
        }

        private float mUsedKilometers;

        public float UsedKilometers
        {
            get { return mUsedKilometers; }
            set
            {
                mUsedKilometers = value;
                NotifyPropertyChanged();
            }
        }

        private string mLicensePlate;

        public string LicensePlate
        {
            get { return mLicensePlate; }
            set
            {
                mLicensePlate = value;
                NotifyPropertyChanged();
            }
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