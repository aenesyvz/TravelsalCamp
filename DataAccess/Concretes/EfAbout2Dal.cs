using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAbout2Dal : EfEntityRepositoryBase<About2, Context>, IAbout2Dal
    {

    }
}
