using Business.Abstract;
using Entities.Concretes;

namespace Business.Concrete
{
    public class SubAboutManager : ISubAboutService 
    {
        private ISubAboutService _subAboutService;
        public SubAboutManager(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
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
