using Entities.Concretes;

namespace Business.Abstract
{
    public interface IAbout2Service
    {
        void Add(About2 about2);
        void Update(About2 about2);
        void Delete(About2 about2);
        List<About2> GetAll();
        About2 GetById(int id);
    }
}
