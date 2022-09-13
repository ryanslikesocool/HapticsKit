// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CoreHaptics/CoreHaptics.h>
//#import "UnityAppController.h"

extern "C" {
bool supportsHaptics() {
	return [[CHHapticEngine capabilitiesForHardware] supportsHaptics];
}

void notificationFeedback(const int *idx) {
	NSInteger newIdx = (NSInteger) idx;
	UINotificationFeedbackType style = (UINotificationFeedbackType) newIdx;
	UINotificationFeedbackGenerator *gen = [[UINotificationFeedbackGenerator alloc] init];
	[gen notificationOccurred:style];
	gen = NULL;
}

void impactFeedback(const int *idx) {
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
