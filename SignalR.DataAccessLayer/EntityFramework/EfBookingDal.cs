using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContect context) : base(context)
        {
        }

        public void BookingStatusApproved(int id)
        {
            using var contex = new SignalRContect();
            var values = contex.Bookings.Find(id);
            values.Description = "Rezervasyon Onaylandı";
            contex.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {

            using var contex = new SignalRContect();
            var values = contex.Bookings.Find(id);
            values.Description = "Rezervasyon İptal Edildi";
            contex.SaveChanges();

        }
    }
}
