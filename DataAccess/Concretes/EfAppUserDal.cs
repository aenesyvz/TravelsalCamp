using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAppUserDal: EfEntityRepositoryBase<AppUser,Context>, IAppUserDal
    {

    }
}
