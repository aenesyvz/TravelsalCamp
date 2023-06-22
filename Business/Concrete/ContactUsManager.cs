using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;
        public ContactUsManager(IContactUsDal _contactUsDal)
        {
            _contactUsDal = _contactUsDal;
        }

        public void Add(ContactUs contactUs)
        {
            _contactUsDal.Add(contactUs);
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            _contactUsDal.ContactUsStatusChangeToFalse(id);
        }

        public void Delete(ContactUs contactUs)
        {
            _contactUsDal.Delete(contactUs);
        }

        public List<ContactUs> GetAll()
        {
            return _contactUsDal.GetAll();
        }

        public List<ContactUs> GetAllContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> GetAllContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public ContactUs GetById(int id)
        {
            return _contactUsDal.Get(x=> x.ContactUsID == id);
        }

        public void Update(ContactUs contactUs)
        {
            _contactUsDal.Update(contactUs);
        }
    }

}
