using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Contrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonailDal;

        public TestimonialManager(ITestimonialDal testimonailDal)
        {
            _testimonailDal = testimonailDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonailDal.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonailDal.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonailDal.GetByID(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonailDal.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonailDal.Update(entity);
        }
    }
}
