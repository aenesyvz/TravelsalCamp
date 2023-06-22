using Core.DataAccess;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
        List<Comment> GetListCommentWithDestination();
        List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
