using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination destination)
        {
            _destinationDal.Add(destination);
        }

        public void Delete(Destination destination)
        {
            _destinationDal.Delete(destination);
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.Get(x => x.DestinationID == id);
        }

        public Destination GetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> GetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public void Update(Destination destination)
        {
            _destinationDal.Update(destination);
        }
    }
}
