#include "HapticsKit.h"

extern "C" {
	void notificationFeedback(const int *idx) {
		NSInteger newIdx = (NSInteger) idx;
		UINotificationFeedbackType style = (UINotificationFeedbackType) newIdx;
		UINotificationFeedbackGenerator *gen = [[UINotificationFeedbackGenerator alloc] init];
		[gen notificationOccurred:style];
		gen = NULL;
	}
	
	void impactFeedback(int *idx) {
		NSInteger newIdx = (NSInteger) idx;
		UIImpactFeedbackStyle style = (UIImpactFeedbackStyle) newIdx;
		UIImpactFeedbackGenerator *gen = [[UIImpactFeedbackGenerator alloc] initWithStyle:(style)];
		[gen impactOccurred];
		gen = NULL;
	}
	
	void selectionFeedback() {
		UISelectionFeedbackGenerator *gen = [[UISelectionFeedbackGenerator alloc] init];
		[gen selectionChanged];
		gen = NULL;
	}
}
