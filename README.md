# HapticsKit
Quick access to iOS haptics functions for Unity.

## Requirements
- A recent version of Unity
- An iPhone 7 or later running iOS 12 or later

## Installation

**Recommended Installation** (Unity Package Manager)
- "Add package from git URL..."
- https://github.com/ryanslikesocool/HapticsKit.git

**Alternate Installation**
- Get the latest [release](https://github.com/ryanslikesocool/HapticsKit/releases)
- Open with the desired Unity project
- Import into the Plugins folder

## Usage
Import HapticsKit into a C# script with `using HapticsKit;`\

Check if the current device supports haptics.
```cs
bool currentDeviceSupportsHaptics = HapticsController.SupportsHaptics;
```

Call one of the methods in `HapticsController`.\
These methods act as a C# wrapper around the Obj-C source.
```cs
HapticsController.NotificationFeedback(NotificationType.Success);
HapticsController.ImpactFeedback(ImpactType.Light);
HapticsController.SelectionFeedback();
//etc...
```

Notification and Impact feedbacks have a range of options
```cs
// Notification
NotificationType.Success
NotificationType.Warning
NotificationType.Error

//Impact
ImpactType.Light
ImpactType.Medium
ImpactType.Heavy
ImpactType.Soft
ImpactType.Rigid
```