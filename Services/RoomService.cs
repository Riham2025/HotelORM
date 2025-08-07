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

        public void CreateRoom(string number) // Adds a new room with the specified room number to the database.
        {
            Room room = new Room { RoomNumber = number, IsAvailable = true }; // This creates a new Room object with the provided room number and sets its availability to true.
            _roomRepo.AddRoom(room); // This line calls the AddRoom method of the RoomRepository to save the new room to the database.
        }

        public void SetRoomAvailable(int roomId, bool isAvailable) // Updates the availability status of a room with the specified room ID in the database.
        {
            _roomRepo.UpdateRoomAvailability(roomId, isAvailable); // This line calls the UpdateRoomAvailability method of the RoomRepository to change the availability status of the room.
        }

        public List<Room> ListRooms() => _roomRepo.GetAllRooms();
    }

}
