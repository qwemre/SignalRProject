using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContect context) : base(context)
        {
        }

        public List<Notification> GetAllNotificationByFalse()
        {
            using var context = new SignalRContect();
            return context.Notifications.Where(x => x.status == false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new SignalRContect();
            return context.Notifications.Where(x => x.status == false).Count();
        }

        public void NotificationStatusChangeToFalse(int id)
        {
            using var context = new SignalRContect();
            var value = context.Notifications.Find(id);
            value.status = false;
            context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            using var context = new SignalRContect();
            var value = context.Notifications.Find(id);
            value.status = true;
            context.SaveChanges();
        }
    }
}
