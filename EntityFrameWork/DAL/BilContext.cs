using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.DAL;

public class BilContext : DbContext
{
    public BilContext()
    {
    }

    public DbSet<Bil> Biler { get; set; }
    public DbSet<Ejer> Ejere { get; set; }
    public DbSet<Reservedel> Reservedel { get; set; }


    //bliver brugt til at oprette noget i DB'en når DB'en oprettes
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ejer>().HasData(
            new Ejer

                { EjerId = 1, ForNavn = "John", SurName = "H" }
        );
        modelBuilder.Entity<Bil>().HasData(new Bil[]
        {
            new Bil
            {
                BilId = 1, Name = "Ford", Weight = 1400, EjerId = 1
            }
        });
        modelBuilder.Entity<Reservedel>().HasData(
            new Reservedel { ReservedelId = 1, Name = "Bremser", Mærke = "Bosch" },
            new Reservedel { ReservedelId = 2, Name = "Oliefilter", Mærke = "Mann" },
            new Reservedel { ReservedelId = 3, Name = "Tændrør", Mærke = "NGK" }
        );
        modelBuilder.Entity("BilReservedel").HasData(
            new { BilerBilId = 1, ReservedeleReservedelId = 1 },
            new { BilerBilId = 1, ReservedeleReservedelId = 2 }
        );
        
    }


    protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=NIELS-HP\\SQLEXPRESS;Initial Catalog=Biler1;Integrated Security=SSPI; TrustServerCertificate=true");
    }
}