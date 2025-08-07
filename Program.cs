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
            RoomService roomService = new RoomService(roomRepo);

            roomService.CreateRoom("101");
            roomService.CreateRoom("102");

            foreach (var room in roomService.ListRooms())
            {
                Console.WriteLine($"Room: {room.RoomNumber} - Available: {room.IsAvailable}");
            }
        }

    }
}
