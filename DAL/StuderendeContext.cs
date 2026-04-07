using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace DAL;

public class StuderendeContext : DbContext
{
        public StuderendeContext()
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=StuderendeDb;Trusted_Connection=True;");
                optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studerende>().HasData(new Studerende[]
            {
               
                new Studerende{Id = 1, Navn = "Niels", StudieStart = new DateTime(2025,04,02),Alder = 25,StudieType = studieType.BACHELOR},
                new Studerende{Id = 2,Navn = "Anne",StudieStart = new DateTime(1998,05,08), Alder = 28,StudieType = studieType.MASTER},
                new Studerende{Id = 3, Navn = "Marie",StudieStart = new DateTime(2004,06,08),Alder = 22,StudieType = studieType.VIDEREUDDANNELSE}
            });
        }
        public DbSet<Studerende> Studerende { get; set; }
        public DbSet<Hold>Hold { get; set; }
        
        
    
}