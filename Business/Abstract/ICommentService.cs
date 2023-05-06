using Entities.Concretes;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
        List<Comment> GetAll();
        Comment GetById(int id);
        List<Comment> GetAllByDestinationIdAndStatus(int destination);
        List<Comment> GetAllByDestinationId(int destination);
    }
}
