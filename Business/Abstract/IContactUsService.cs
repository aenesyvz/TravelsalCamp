using Entities.Concretes;

namespace Business.Abstract
{
    public interface IContactUsService
    {
        void Add(ContactUs contactUs);
        void Update(ContactUs contactUs); 
        void Delete(ContactUs contactUs);
        List<ContactUs> GetAll();
        ContactUs GetById(int id);

        List<ContactUs> GetAllContactUsByTrue();
        List<ContactUs> GetAllContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
