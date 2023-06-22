using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IReservationDal : IEntityRepository<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
