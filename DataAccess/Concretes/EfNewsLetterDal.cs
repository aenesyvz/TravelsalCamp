using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfNewsLetterDal : EfEntityRepositoryBase<NewsLetter, Context>, INewsLetterDal
    {

    }
}
