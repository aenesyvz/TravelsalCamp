using Entities.Concretes;

namespace Business.Abstract
{
    public interface IDestinationService
    {
        void Add(Destination destination);
        void Update(Destination destination);
        void Delete(Destination destination);
        List<Destination> GetAll();
        Destination GetById(int id);
    }
}
