using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class GuideManager : IGuideService 
    {
        private IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void Add(Guide guide)
        {
            _guideDal.Add(guide);
        }

        public void Delete(Guide guide)
        {
           _guideDal.Delete(guide);
        }

        public List<Guide> GetAll()
        {
           return _guideDal.GetAll();
        }

        public Guide GetById(int id)
        {
            return _guideDal.Get(x => x.Id == id);
        }

        public void Update(Guide guide)
        {
            _guideDal.Update(guide);
        }
    }
}
