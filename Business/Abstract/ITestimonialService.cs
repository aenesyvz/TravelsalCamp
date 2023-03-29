using Entities.Concretes;

namespace Business.Abstract
{
    public interface ITestimonialService
    {
        void Add(Testimonial testimonial);
        void Update(Testimonial testimonial); 
        void Delete(Testimonial testimonial); 
        void GetAll(); 
        void GetById(int id);
    }
}
