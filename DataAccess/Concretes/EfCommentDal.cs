using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, Context>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x => x.DestinationID == id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
