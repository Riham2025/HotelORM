using HotelORM.Models;

namespace HotelORM.Services
{
    public interface IRoomService
    {
        void CreateRoom(string number);
        List<Room> ListRooms();
        void SetRoomAvailable(int roomId, bool isAvailable);
    }
}