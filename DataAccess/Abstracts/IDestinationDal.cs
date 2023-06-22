using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IDestinationDal : IEntityRepository<Destination>
    {
        Destination GetDestinationWithGuide(int id);
        List<Destination> GetLast4Destinations();
    }
}
