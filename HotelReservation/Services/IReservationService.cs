using HotelReservation.Domain;
using System;
using System.Collections.Generic;

namespace HotelReservation.Services
{
    public interface IReservationService
    {
        string FindCheapestHotel(GuestCategory guestCategory, List<DateTime> dates);
    }
}
