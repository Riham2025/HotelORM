using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelORM.Models
{
    // This class represents a hotel room entity in the database
    public class Room 
    {
        // Properties of the Room class
        [Key] 
        public int RoomId { get; set; } // Unique identifier for the room
        public string RoomNumber { get; set; } // Room number or identifier
        public bool IsAvailable { get; set; } // Indicates if the room is available for booking
    }


}
