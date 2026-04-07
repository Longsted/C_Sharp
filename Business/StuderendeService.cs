namespace Business;
using DAL;
using Domain;


public class StuderendeService
{
    public Studerende GetById(int id)
    {
        return StuderendeRepository.GetById(id);
    }

    public List<Studerende> GetAll()
    {
        return StuderendeRepository.GetAll();
    }

    public void Create(Studerende s)
    {
        StuderendeRepository.CreateStuderende(s);
    }

    public void Delete(int id)
    {
        StuderendeRepository.DeleteStuderende(id);
    }

    public void Update(Studerende s)
    {
        StuderendeRepository.UpdateStuderende(s);
    }
}