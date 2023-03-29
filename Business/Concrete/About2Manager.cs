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
            throw new NotImplementedException();
        }

        public void Delete(About2 about2)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About2 about2)
        {
            throw new NotImplementedException();
        }
    }
}
