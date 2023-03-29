using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfDestinationDal : EfEntityRepositoryBase<Destination, Context>, IDestinationDal
    {

    }
}
