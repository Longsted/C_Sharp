using Domain;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace DAL;

public class StuderendeRepository
{
    public static Studerende GetById(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            return context.Studerende.Find(id) ?? throw new InvalidOperationException();
        }
    }

    public static  List<Studerende> GetAll()
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            return context.Studerende.ToList();
        }
    }

    public static void CreateStuderende(Studerende studerende)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            context.Studerende.Add(studerende);
            context.SaveChanges();
        }
    }

    public static void DeleteStuderende(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            var s = context.Studerende.Find(id);
            if (s != null)
            {
                context.Studerende.Remove(s);
                context.SaveChanges();
            }
           
        }
    }

    public static void UpdateStuderende(Studerende s)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            Domain.Studerende dataemp = context.Studerende.Find(s.Id);
            var existing = context.Studerende.Find(s);
            if (existing != null)
            {
                existing.Navn = s.Navn;
                existing.Alder = s.Alder;
                existing.StudieStart = s.StudieStart;
                existing.StudieType = s.StudieType;
                context.SaveChanges();
            }
           
        }
    }
}