using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Testimonial:IEntity
    {
        public int TestimonialID { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
