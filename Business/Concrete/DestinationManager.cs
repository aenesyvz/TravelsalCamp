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
            return _destinationDal.Get(x => x.Id == id);
        }

        public void Update(Destination destination)
        {
            _destinationDal.Update(destination);
        }
    }
}
