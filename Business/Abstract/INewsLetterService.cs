using Entities.Concretes;

namespace Business.Abstract
{
    public interface INewsLetterService
    {
        void Add(NewsLetter newsLetter); 
        void Update(NewsLetter newsLetter);
        void Delete(NewsLetter newsLetter);
        List<NewsLetter> GetAll(); 
        NewsLetter GetById(int id);
    }
}
