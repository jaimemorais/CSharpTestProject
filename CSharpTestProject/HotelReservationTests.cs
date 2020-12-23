using HotelReservation.Domain;
using HotelReservation.Repository;
using HotelReservation.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace CSharpTestProject
{
    public class HotelReservationTests
    {
        [Fact]
        public void ShouldBeLakewoodForRegularGuest()
        {
            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2009, 03, 16),
                new DateTime(2009, 03, 17),
                new DateTime(2009, 03, 18)
            };


            string cheapestHotel = new ReservationService(new HotelRepository()).FindCheapestHotel(GuestCategory.Regular, dates);

            Assert.Equal("Lakewood", cheapestHotel);
        }

        [Fact]
        public void ShouldBeBridgewoodForRegularGuest()
        {
            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2009, 03, 20),
                new DateTime(2009, 03, 21),
                new DateTime(2009, 03, 22)
            };

            string cheapestHotel = new ReservationService(new HotelRepository()).FindCheapestHotel(GuestCategory.Regular, dates);

            Assert.Equal("Bridgewood", cheapestHotel);
        }

        [Fact]
        public void ShouldBeRidgewoodForRewardsGuest()
        {
            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2009, 03, 26),
                new DateTime(2009, 03, 27),
                new DateTime(2009, 03, 28)
            };

            string cheapestHotel = new ReservationService(new HotelRepository()).FindCheapestHotel(GuestCategory.Rewards, dates);

            Assert.Equal("Ridgewood", cheapestHotel);
        }

    }
}
