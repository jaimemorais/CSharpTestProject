using HotelReservation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation.Domain
{
    public class Hotel
    {
        public Hotel(string name, int rating, List<Price> priceList)
        {
            Name = name;
            Rating = rating;
            PriceList = priceList;
        }

        public string Name { get; private set; }
        public int Rating { get; private set; }

        public List<Price> PriceList { get; set; }

        

        public decimal CalculateReservationValue(GuestCategory guestCategory, List<DateTime> dates)
        {
            decimal total = 0;

            foreach (DateTime date in dates)
            {
                total += PriceList
                    .First(price => price.GuestCategory == guestCategory && price.Weekend == date.IsWeekend())
                    .Value;
            }

            return total;
        }
    }
}
