namespace RoomBooking_SOLID_Examples
{
    public interface IAuthentication
    {
        bool Authenticate(string username, string password);
    }
}