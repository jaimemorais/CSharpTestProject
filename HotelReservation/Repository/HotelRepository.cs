using HotelReservation.Domain;
using System.Collections.Generic;

namespace HotelReservation.Repository
{
    public class HotelRepository : IHotelRepository
    {
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel("Lakewood", 3, 
                    new List<Price>() {
                        new Price(GuestCategory.Regular, 110, false),
                        new Price(GuestCategory.Rewards, 80, false),
                        new Price(GuestCategory.Regular, 90, true),
                        new Price(GuestCategory.Rewards, 80, true)
                    }),

                new Hotel("Bridgewood", 4,
                    new List<Price>() {
                        new Price(GuestCategory.Regular, 160, false),
                        new Price(GuestCategory.Rewards, 110, false),
                        new Price(GuestCategory.Regular, 60, true),
                        new Price(GuestCategory.Rewards, 50, true)
                    }),

                new Hotel("Ridgewood", 5,
                    new List<Price>() {
                        new Price(GuestCategory.Regular, 220, false),
                        new Price(GuestCategory.Rewards, 100, false),
                        new Price(GuestCategory.Regular, 150, true),
                        new Price(GuestCategory.Rewards, 40, true)
                    }),
            };

        }

    }
}
