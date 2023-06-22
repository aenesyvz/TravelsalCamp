using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAccountDal : EfEntityRepositoryBase<Account, Context>, IAccountDal
    {

    }
}
