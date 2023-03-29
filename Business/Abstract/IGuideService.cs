using Entities.Concretes;

namespace Business.Abstract
{
    public interface IGuideService
    {
        void Add(Guide guide);
        void Update(Guide guide); 
        void Delete(Guide guide); 
        void GetAll(); 
        void GetById(int id);
    }
}
