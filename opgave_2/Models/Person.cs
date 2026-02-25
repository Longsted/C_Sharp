using System.Diagnostics.CodeAnalysis;

namespace opgave_2.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
    public string Zip { get; set; }
    public string City { get; set; }
    private List<string> phoneNumbers = new List<string>();
    
    public string PhoneNumbers
    {
        get => string.Join(", ", phoneNumbers);
    }

    private DateTime birthday;
    public DateTime Birthday
    {
        get => birthday;
        set
        {
            if (Age > 0 && Age < 120)
            {
                birthday = value;
            }
            else
            {
                throw new ArgumentException("din alder er ikke accepteret");
            }
        }
    }

    public int Age
    {
        get
        {
            int age = DateTime.Now.Year - birthday.Year;

            if (DateTime.Now.Month < birthday.Month ||
                (DateTime.Now.Month == birthday.Month && DateTime.Now.Day < birthday.Day))
            {
                age--;
            }

            return age;
        }
    }
    
    


    public Person(string firstName, string lastName, string adress, string zip, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        Adress = adress;
        Zip = zip;
        City = city;
    }

    public void AddPhone(string phone)
    {
        phoneNumbers.Add(phone);
    }
}