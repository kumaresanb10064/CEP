using CodinWebApp.Components.Pages;
using CodinWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System.ComponentModel.DataAnnotations;

namespace CodinWebApp
{
    public class ApplicationDbContext : DbContext
    {

        

        public DbSet<users> users { get; set; }
        public DbSet<employees> employees { get; set; } // DbSet for Employee entities

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Set the base path to the directory containing appsettings.json
        .AddJsonFile("appsettings.json") // Load appsettings.json
        .Build(); // Build the configuration

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            //string connectionString = "Host=172.17.0.2;Port=5432;Username=postgres;Password=Sql@123;Database=CodinWebApp;";
            //string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Sql@123;Database=CodinWebApp;";

            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    //public class employees
    //{
    //    [Key]
    //    public int employee_id { get; set; }
    //    public string? employee_name { get; set; }
    //    public string? designation { get; set; }
    //    public DateOnly? doj { get; set; }
    //    public DateOnly? dol { get; set; }
    //    public string? email { get; set; }
    //}

    //public class users
    //{
    //    [Key]
    //    public int user_id { get; set; }
    //    public string username { get; set; }
    //    public string password { get; set; }
    //}
}
