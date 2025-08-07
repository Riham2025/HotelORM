using HotelORM.Models;

namespace HotelORM.Repository
{
    public interface IRoomRepository
    {
        void AddRoom(Room room);
        List<Room> GetAllRooms();
        void UpdateRoomAvailability(int roomId, bool available);
    }
}