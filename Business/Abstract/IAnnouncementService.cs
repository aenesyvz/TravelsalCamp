using Entities.Concretes;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        void Add(Announcement announcement);
        void Update(Announcement announcement);
        void Delete(Announcement announcement);
        List<Announcement> GetAll();
        Announcement GetById(int id);
    }
}
