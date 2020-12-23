using HotelReservation.Domain;
using HotelReservation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation.Services
{
    public class ReservationService : IReservationService
    {

        private readonly IHotelRepository _hotelRepository;

        public ReservationService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public string FindCheapestHotel(GuestCategory guestCategory, List<DateTime> dates)
        {
            List<Hotel> hotelList = _hotelRepository.GetHotels();

            return hotelList
                    .OrderBy(h => h.CalculateReservationValue(guestCategory, dates))
                    .ThenByDescending(h => h.Rating)
                    .First()
                    .Name;

            /*
            List<Tuple<Hotel, decimal>> hotelReservationValues = new List<Tuple<Hotel, decimal>>(); 
            foreach (Hotel hotel in hotelList)
            {
                hotelReservationValues.Add(new Tuple<Hotel, decimal>(hotel, hotel.CalculateReservationValue(guestCategory, dates)));
            }


            return hotelReservationValues
                .OrderBy(t => t.Item2)
                .ThenByDescending(t => t.Item1.Rating)
                .First()
                .Item1.Name;
            */

        }

    }
}
