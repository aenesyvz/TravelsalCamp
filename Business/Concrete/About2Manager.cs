using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class About2Manager : IAbout2Service
    {
        private IAbout2Dal _about2Dal;
        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void Add(About2 about2)
        {
            _about2Dal.Add(about2);
        }

        public void Delete(About2 about2)
        {
            _about2Dal.Delete(about2);
        }

        public List<About2> GetAll()
        {
            return _about2Dal.GetAll();
        }

        public About2 GetById(int id)
        {
            return _about2Dal.Get(x => x.About2ID == id);
        }

        public void Update(About2 about2)
        {
            _about2Dal.Update(about2);
        }
    }
}
