namespace HotelReservation.Domain
{
    public class Price
    {
        public Price(GuestCategory guestCategory, decimal value, bool weekend)
        {
            GuestCategory = guestCategory;
            Value = value;
            Weekend = weekend;
        }

        public GuestCategory GuestCategory { get; private set; }

        public decimal Value { get; private set; }

        public bool Weekend { get; private set; }

    }
}