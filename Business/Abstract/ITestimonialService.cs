using Entities.Concretes;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        void Add(Testimonial testimonial);
        void Update(Testimonial testimonial); 
        void Delete(Testimonial testimonial); 
        List<Testimonial> GetAll(); 
        Testimonial GetById(int id);
    }
}
