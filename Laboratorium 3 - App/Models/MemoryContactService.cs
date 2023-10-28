using Laboratorium_3___App.Models;
    public class MemoryContactService:IContactService
{
    private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>()
    {
         {1, new Contact() {Id=1, Name="Adam", Email = "adam@wsei.edu.pl", Phone="11223322", Birth = new DateTime()} }
    };
        
public void Add(Contact contact)
    {
        contact.Id = contact.Id + 1;
        _items[contact.Id] = contact;
    }

    public List<Contact> FindAll()
    {
        return _items.Values.ToList();
    }

    public Contact? FindById(int id)
    {
        return _items[id];
    }

    public void RemoveById(int id)
    {
        _items?.Remove(id); 
    }

    public void Update(Contact contact)
    {
        _items[contact.Id] = contact;
    }
}

