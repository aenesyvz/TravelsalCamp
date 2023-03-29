using Business.Abstract;
using Entities.Concretes;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService 
    {
        private ITestimonialService _testimonialService;
        public TestimonialManager(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public void Add(Testimonial testimonial)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial testimonial)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial testimonial)
        {
            throw new NotImplementedException();
        }
    }
}
