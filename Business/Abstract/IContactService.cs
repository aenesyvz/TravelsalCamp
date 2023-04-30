using Entities.Concretes;

namespace Business.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
        List<Contact> GetAll();
        Contact GetById(int id);
    }
}
