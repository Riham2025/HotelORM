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
        private readonly RoomRepository _roomRepo; // This field holds an instance of the RoomRepository, which is used to interact with the room data in the database.

        public RoomService(RoomRepository roomRepo) // Constructor that initializes the RoomService with a RoomRepository instance.
        {
            _roomRepo = roomRepo; // This allows the RoomService to use the methods defined in the RoomRepository to perform operations on room data.
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
