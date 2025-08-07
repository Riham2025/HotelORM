using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelORM.Models;
using HotelORM.Repository;

namespace HotelORM.Services
{
    public class RoomService // This class is responsible for managing room-related operations in the hotel management system.
    {
        private readonly RoomRepository _roomRepo;

        public RoomService(RoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public void CreateRoom(string number)
        {
            Room room = new Room { RoomNumber = number, IsAvailable = true };
            _roomRepo.AddRoom(room);
        }

        public void SetRoomAvailable(int roomId, bool isAvailable)
        {
            _roomRepo.UpdateRoomAvailability(roomId, isAvailable);
        }

        public List<Room> ListRooms() => _roomRepo.GetAllRooms();
    }

}
