using Entities.Concretes;

namespace Business.Abstract
{
    public interface ISubAboutService
    {
        void Add(SubAbout subAbout);
        void Update(SubAbout subAbout);
        void Delete(SubAbout subAbout);
        List<SubAbout> GetAll(); 
        SubAbout GetById(int id);
    }
}
