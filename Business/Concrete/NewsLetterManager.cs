using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class NewsLetterManager : INewsLetterService 
    { 
        private INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Add(NewsLetter newsLetter)
        {
           _newsLetterDal.Add(newsLetter);  
        }

        public void Delete(NewsLetter newsLetter)
        {
            _newsLetterDal.Delete(newsLetter);
        }

        public List<NewsLetter> GetAll()
        {
           return _newsLetterDal.GetAll();
        }

        public NewsLetter GetById(int id)
        {
            return _newsLetterDal.Get(x => x.Id == id);
        }

        public void Update(NewsLetter newsLetter)
        {
           _newsLetterDal.Update(newsLetter);
        }
    }
}
