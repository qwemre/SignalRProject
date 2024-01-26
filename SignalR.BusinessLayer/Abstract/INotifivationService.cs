using SignalR.EntitiyLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface INotifivationService : IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();
        List<Notification> TGetAllNotificationByFalse();

        void TNotificationStatusChangeToTrue(int id);
        void TNotificationStatusChangeToFalse(int id);
    }
}
