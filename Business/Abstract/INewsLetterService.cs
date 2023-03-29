using Entities.Concretes;

namespace Business.Abstract
{
    public interface INewsLetterService
    {
        void Add(NewsLetter newsLetter); 
        void Update(NewsLetter newsLetter);
        void Delete(NewsLetter newsLetter);
        void GetAll(); 
        void GetById(int id);
    }
}
