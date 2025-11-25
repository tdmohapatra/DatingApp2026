using System;
using API.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

#region 
//******************************************************************************
// The below code is old faishoned 
// public class AppDbContext:DbContext
// {
//     public AppDbContext(DbContextOptions options) : base (options)
//     {
        
//     }
// }
#endregion

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    // -- define the table that is goint to create in database using ef
    public DbSet <AppUser> Users { get; set; }
}
// we need to register db context to our program.cs class who is the entry point of the application
