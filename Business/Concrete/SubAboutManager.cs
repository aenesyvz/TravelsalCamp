using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService 
    {
        private ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout subAbout)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubAbout subAbout)
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

        public void Update(SubAbout subAbout)
        {
            throw new NotImplementedException();
        }
    }
}
