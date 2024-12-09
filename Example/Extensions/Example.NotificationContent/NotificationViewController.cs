using ObjCRuntime;
using UserNotifications;
using UserNotificationsUI;

namespace Example.NotificationContent
{
    [Register("NotificationViewController")]
	public class NotificationViewController : UIViewController, IUNNotificationContentExtension
    {
        protected NotificationViewController(NativeHandle handle) : base(handle)
        {
        }

        public void DidReceiveNotification(UNNotification notification)
        {
        }
    }
}

