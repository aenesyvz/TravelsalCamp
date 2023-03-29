using Entities.Concretes;

namespace Business.Abstract
{
    public interface ISubAboutService
    {
        void Add(SubAbout subAbout);
        void Update(SubAbout subAbout);
        void Delete(SubAbout subAbout);
        void GetAll(); 
        void GetById(int id);
    }
}
