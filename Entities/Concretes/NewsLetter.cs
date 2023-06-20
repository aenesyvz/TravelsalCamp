using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class NewsLetter:IEntity
    {
        public int NewsletterID { get; set; }
        public string Mail { get; set; }
    }
}
