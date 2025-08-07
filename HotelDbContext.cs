using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelORM.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelORM
{
    public class HotelDbContext : DbContext
    {
        // This class represents the database context for the hotel management system.
        // It will be used to interact with the database, such as querying and saving data.
        // In a real application, this would typically inherit from DbContext in Entity Framework.
        // For now, this class is empty and serves as a placeholder for future implementation.

         
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True;");// Connection string to the database
            }

            public DbSet<Room> Rooms { get; set; } // Represents a collection of Room entities in the database.



    }
}
