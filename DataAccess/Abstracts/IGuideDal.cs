using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IGuideDal : IEntityRepository<Guide>
    {
        void ChangeToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
    }
}
