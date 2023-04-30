using Entities.Concretes;

namespace Business.Abstract
{
    public interface IFeauteService
    {
        void Add(Feature feature);
        void Update(Feature feature);
        void Delete(Feature feature);
        List<Feature> GetAll();
        Feature GetById(int id);
    }
}
