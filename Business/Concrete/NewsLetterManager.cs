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
            throw new NotImplementedException();
        }

        public void Delete(NewsLetter newsLetter)
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

        public void Update(NewsLetter newsLetter)
        {
            throw new NotImplementedException();
        }
    }
}
