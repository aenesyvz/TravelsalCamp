using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfFeatureDal : EfEntityRepositoryBase<Feature, Context>, IFeatureDal
    {

    }
}
