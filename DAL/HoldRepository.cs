using Domain;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace DAL;

public class HoldRepository
{
    public static List<Hold> GetAllHold()
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            return context.Hold.ToList();
        }
    }

    public static Hold? GetHoldById(int id)
    {
        using StuderendeContext context = new StuderendeContext();
        return context.Hold.Include(h
            => h.Studerendes).FirstOrDefault(h => h.Id == id);
    }

    public static void AddStuderende(int holdId, int studerendeId)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            
            var studerende =  context.Studerende.Find(studerendeId);

            if ( studerende != null)
            {
                studerende.HoldId = holdId;
                context.SaveChanges();
            }
        }
    }

    public static void RemoveStuderende(int studerendeId)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            var studerende = context.Studerende.Find(studerendeId);
            

            if (studerende != null)
            {
                studerende.HoldId = null;
              context.SaveChanges();
            }
        }
    }
    public static void CreateHold(Hold hold)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            context.Hold.Add(hold);
            context.SaveChanges();
        }
    }

    public static void DeleteHold(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            var s = context.Hold.Find(id);
            if (s != null)
            {
                context.Hold.Remove(s);
                context.SaveChanges();
            }
        }
    }

    public static List<Studerende> StuderendePåHold(int holdId)
    {
        using var context = new StuderendeContext();

        return context.Studerende
            .Where(s => s.HoldId == holdId)
            .ToList();
    }
}