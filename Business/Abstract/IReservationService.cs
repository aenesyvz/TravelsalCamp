using Entities.Concretes;

namespace Business.Abstract
{
    public interface IReservationService
    {
        void Add(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<Reservation> GetAll();
        Reservation GetById(int id);
        List<Reservation> GetAllWithReservationByWaitAprroval(int id);
        List<Reservation> GetAllWithReservationByAccepted(int id);
        List<Reservation> GetAllWithReservationByPrevious(int id);
    }
}
