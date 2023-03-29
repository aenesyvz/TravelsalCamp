using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class NewsLetter:IEntity
    {
        public int Id { get; set; }
        public string Mail { get; set; }
    }
}
