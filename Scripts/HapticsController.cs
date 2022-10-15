// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.InteropServices;

namespace HapticsKit {
    public class HapticsController {
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern bool supportsHaptics();

    [DllImport("__Internal")]
    private static extern void notificationFeedback(int idx);

    [DllImport("__Internal")]
    private static extern void impactFeedback(int idx);

    [DllImport("__Internal")]
    private static extern void selectionFeedback();
#endif

        public static void NotificationFeedback(NotificationType feedback) {
#if UNITY_IOS && !UNITY_EDITOR
        notificationFeedback((int)feedback);
#endif
        }

        public static void ImpactFeedback(ImpactType feedback) {
#if UNITY_IOS && !UNITY_EDITOR
        impactFeedback((int)feedback);
#endif
        }

        public static void SelectionFeedback() {
#if UNITY_IOS && !UNITY_EDITOR
        selectionFeedback();
#endif
        }

        public static bool SupportsHaptics {
            get {
#if UNITY_IOS && !UNITY_EDITOR
                return supportsHaptics();
#else
                return false;
#endif
            }
        }
    }
}