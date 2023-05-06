using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(int id)
        {
            Comment deleteComment = _commentDal.Get(x => x.Id == id);
            _commentDal.Delete(deleteComment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();    
        }

        public List<Comment> GetAllByDestinationId(int destinationId)
        {
            return _commentDal.GetAll(x => x.DestinationId == destinationId);
        }

        public List<Comment> GetAllByDestinationIdAndStatus(int destinationId)
        {
            return _commentDal.GetAll(x => x.DestinationId == destinationId && x.Status == true);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x=>x.Id== id);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
