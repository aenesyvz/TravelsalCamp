using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
        }

        public void Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
           return _announcementDal.Get(x=> x.AnnouncementID == id);
        }

        public void Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
        }
    }

}
