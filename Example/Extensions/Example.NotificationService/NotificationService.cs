using Foundation;
using ObjCRuntime;
using UserNotifications;

namespace Example.NotificationService
{
    [Register("NotificationService")]
	public class NotificationService : UNNotificationServiceExtension
    {
        protected NotificationService(NativeHandle handle) : base(handle)
        {
        }
    }
}
