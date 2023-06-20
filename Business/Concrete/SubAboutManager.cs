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
            _subAboutDal.Add(subAbout);
        }

        public void Delete(SubAbout subAbout)
        {
            _subAboutDal.Delete(subAbout);
        }

        public List<SubAbout> GetAll()
        {
            return _subAboutDal.GetAll();
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.Get(x=>x.SubAboutID== id);
        }

        public void Update(SubAbout subAbout)
        {
           _subAboutDal.Update(subAbout);
        }
    }
}
