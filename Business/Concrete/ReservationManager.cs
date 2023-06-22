using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Add(Reservation reservation)
        {
            _reservationDal.Add(reservation);
        }

        public void Delete(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public List<Reservation> GetAllWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetAllWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetAllWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x=> x.ReservationID == id); 
        }

        public void Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }
    }

}
