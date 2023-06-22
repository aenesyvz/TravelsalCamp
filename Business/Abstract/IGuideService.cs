using Entities.Concretes;

namespace Business.Abstract
{
    public interface IGuideService
    {
        void Add(Guide guide);
        void Update(Guide guide); 
        void Delete(Guide guide); 
        List<Guide> GetAll(); 
        Guide GetById(int id);
        void ChangeToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
    }
}
