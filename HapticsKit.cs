using System.Runtime.InteropServices;

namespace HapticsKit
{
    public class HapticsController
    {
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void notificationFeedback(int idx);

    [DllImport("__Internal")]
    private static extern void impactFeedback(int idx);

    [DllImport("__Internal")]
    private static extern void selectionFeedback();
#endif

        public static void NotificationFeedback(NotificationType feedback)
        {
#if UNITY_IOS && !UNITY_EDITOR
        notificationFeedback((int)feedback);
#endif
        }

        public static void ImpactFeedback(ImpactType feedback)
        {
#if UNITY_IOS && !UNITY_EDITOR
        impactFeedback((int)feedback);
#endif
        }

        public static void SelectionFeedback()
        {
#if UNITY_IOS && !UNITY_EDITOR
        selectionFeedback();
#endif
        }
    }

    public enum NotificationType
    {
        Success = 0,
        Warning = 1,
        Error = 2,
    }

    public enum ImpactType
    {
        Light = 0,
        Medium = 1,
        Heavy = 2,
    }
}