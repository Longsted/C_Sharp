namespace Business;

using DAL;
using Domain;

public class HoldService
{
    public Hold GetByID(int holdId)
    {
        return HoldRepository.GetHoldById(holdId);
    }

    public List<Hold> GetAll()
    {
        return HoldRepository.GetAllHold();
    }

    public void CreateHold(Hold hold)
    {
        HoldRepository.CreateHold(hold);
    }

    public void DeleteHold(int id)
    {
        HoldRepository.DeleteHold(id);
    }

    public List<Studerende> StuderendePåHold(Hold hold)
    {
        if (hold == null)
            return new List<Studerende>();

        return HoldRepository.StuderendePåHold(hold.Id);
    }

    public void AddStuderende(int holdId, int studerendeId)
    { 
        HoldRepository.AddStuderende(holdId, studerendeId);
    }

    public void RemoveStuderende(int studerendeId)
    {
        HoldRepository.RemoveStuderende(studerendeId);
    }
}