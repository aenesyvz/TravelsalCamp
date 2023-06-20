using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService 
    {
        private ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
            _testimonialDal.Add(testimonial);
        }

        public void Delete(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();    
        }

        public Testimonial GetById(int id)
        {
           return _testimonialDal.Get(x=>x.TestimonialID== id);
        }

        public void Update(Testimonial testimonial)
        {
            _testimonialDal.Update(testimonial);
        }
    }
}
