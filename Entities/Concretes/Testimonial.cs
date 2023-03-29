using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Testimonial:IEntity
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
