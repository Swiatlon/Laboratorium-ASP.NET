using Models.Contact;

public interface IContactService
{
    void Add(Contact contact);
    void RemoveById(int id);
    void Update(Contact contact);

    List<Contact> FindAll();
    Contact? FindById(int id);
}
