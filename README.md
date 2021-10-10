# HapticsKit
Quick access to iOS haptics functions for Unity.

## Installation

**Recommended Installation**
Add via the Unity Package Manager\
"Add package from git URL..."\
https://github.com/ryanslikesocool/HapticsKit.git\
Add\

Not-so Recommended Installation
Get the latest release\
Open with the desired Unity project\
Import into the Plugins folder\

## Usage
Import HapticsKit into a C# script with `using HapticsKit;`\
Call one of the methods in `HapticsController`.\
These methods act as a C# wrapper around the Obj-C source.\

```cs
HapticsController.NotificationFeedback(NotificationType.Success);
HapticsController.ImpactFeedback(ImpactType.Light);
HapticsController.SelectionFeedback();
//etc...
```
