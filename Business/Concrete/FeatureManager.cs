using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class FeatureManager : IFeauteService 
    {
        private IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal= featureDal;
        }

        public void Add(Feature feature)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature feature)
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

        public void Update(Feature feature)
        {
            throw new NotImplementedException();
        }
    }
}
