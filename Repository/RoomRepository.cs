using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelORM.Models;

namespace HotelORM.Repository
{
    public class RoomRepository 
                                // This class is responsible for managing room data in the hotel management system.
                                // It provides methods to add, retrieve, and update room information in the database.
                                // The class interacts with the HotelDbContext to perform database operations.
                                // In a real application, this would typically implement an interface for better abstraction.
    {
        private readonly HotelDbContext _context; // Represents the database context used to interact with the database.

        public RoomRepository(HotelDbContext context) // Constructor that initializes the RoomRepository with a HotelDbContext instance.
        {
            _context = context; 
        }

        public void AddRoom(Room room) // Adds a new room to the database.
        {
            _context.Rooms.Add(room); // This line adds the room entity to the Rooms DbSet in the context.
            _context.SaveChanges(); // This line saves the changes to the database, persisting the new room entity.
        }

        public List<Room> GetAllRooms() => _context.Rooms.ToList();

        public void UpdateRoomAvailability(int roomId, bool available)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.RoomId == roomId);
            if (room != null)
            {
                room.IsAvailable = available;
                _context.SaveChanges();
            }
        }
    }

}
