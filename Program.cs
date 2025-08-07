using HotelORM.Repository;
using HotelORM.Services;

namespace HotelORM
{
    public class Program
    {
        static void Main(string[] args)
        {
            using HotelDbContext context = new HotelDbContext(); 
            context.Database.EnsureCreated(); 

            RoomRepository roomRepo = new RoomRepository(context); // This creates an instance of the RoomRepository, which will be used to interact with the room data in the database.
            RoomService roomService = new RoomService(roomRepo); // This creates an instance of the RoomService, which will handle room-related operations using the RoomRepository.

            roomService.CreateRoom("101"); // This adds a new room with the number "101" to the database.
            roomService.CreateRoom("102"); // This adds another room with the number "102" to the database.

            foreach (var room in roomService.ListRooms()) // This retrieves all rooms from the database and iterates through them.
            {
                Console.WriteLine($"Room: {room.RoomNumber} - Available: {room.IsAvailable}"); // This prints the room number and its availability status to the console.
            }
        }

    }
}
