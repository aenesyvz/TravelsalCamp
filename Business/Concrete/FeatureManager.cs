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
            _featureDal.Add(feature);
        }

        public void Delete(Feature feature)
        {
            _featureDal.Delete(feature);
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            return _featureDal.Get(x=>x.Id == id);
        }

        public void Update(Feature feature)
        {
            _featureDal.Update(feature);
        }
    }
}
