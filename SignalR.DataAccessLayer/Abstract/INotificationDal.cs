using SignalR.EntitiyLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface INotificationDal : IGenericDal<Notification>
	{
		int NotificationCountByStatusFalse();
		List<Notification> GetAllNotificationByFalse();

		void NotificationStatusChangeToTrue(int id);
		void NotificationStatusChangeToFalse(int id);

	}
}
