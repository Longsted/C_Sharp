using EntityFrameWork;
using EntityFrameWork.DAL;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

/*når man laver ændringer i entities
 dotnet ef migrations add NavnPåÆndring
dotnet ef database update*/

/*hurtig ændring i skoleprojekt
 dotnet ef database drop
dotnet ef database update*/

using (BilContext context = new BilContext())
{
    // context.Database.EnsureCreated();
    //include for at hente alt data fra DB
    var ejere = context.Ejere.Include(e=> e.Biler).ThenInclude(b => b.Reservedele).ToList();
    foreach (var v in ejere)
    {
        Console.WriteLine($"{v.ForNavn} {v.SurName}");
        foreach (var b in v.Biler)
        {
            Console.WriteLine($" id {b.BilId}  navn {b.Name}  vægt {b.Weight} \nReservedele" + string.Join("," ,b.Reservedele.Select(r => r.Name)));
            
            
            
            
        }
    }


    string input;
    while ((input = Console.ReadLine()) != "quit")
    {
        switch (input)
        {
            case "d": DeleteCar(context);
                break;
            
            case "o": ChangeInOwner(context);
                break;
        }
    }
    

    foreach (var v in ejere)
    {
        Console.WriteLine($"{v.ForNavn} {v.SurName}");
        foreach (var b in v.Biler)
        {
            Console.WriteLine($" id {b.BilId}  navn {b.Name}  vægt {b.Weight}");
        }
    }
}

void ChangeInOwner(BilContext context)
{
    Console.WriteLine("insert ownerID");
    int id = int.Parse(Console.ReadLine()!);

    var ejer = context.Ejere.Find(id);
    if (ejer != null)
    {
        Console.WriteLine("ændring i fornavn = 1 ændring i efternavn = 2");

        string change;
        while ((change = Console.ReadLine()!) != "quit")
        {
            switch (change)
            {
                case "1":
                    Console.WriteLine("indtast nyt fornavn");
                    ejer.ForNavn = Console.ReadLine()!;
                    break;
                case "2":
                    Console.WriteLine("indtast nyt efternavn");
                    ejer.SurName = Console.ReadLine()!;
                    break;
            }

        }
       
        context.SaveChanges();
    }
}

void DeleteCar(BilContext context)
{
    foreach (var bil1 in context.Biler)
    {
        Console.WriteLine($"id= {bil1.BilId}  {bil1.Name} og ejer = {bil1.Ejer.ForNavn} {bil1.Ejer.SurName}");
    }
    Console.WriteLine("Indtast bil id der skal slettes:");

    int id = int.Parse(Console.ReadLine()!);

    var bil = context.Biler.Find(id);
    
    if (bil != null)
    {
        context.Biler.Remove(bil);
        context.SaveChanges();

        Console.WriteLine("Bil slettet");
    }
}

Console.WriteLine("Database oprettet");

