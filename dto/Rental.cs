using System;

namespace Car_Rental.dto
{
    public class Rental
    {
        public Car rentedCar;
        public Customer rentalCustomer { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int rentalDays { get; set; }
    }
}