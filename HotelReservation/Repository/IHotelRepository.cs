using HotelReservation.Domain;
using System.Collections.Generic;

namespace HotelReservation.Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotels();
    }
}
