# GOOD-PRIZE LIVE — ANDROID BUILD CHECKLIST

This source has been prepared as far as possible without a Unity/Android build
environment.

Target:
- Android APK
- Product: GOOD-PRIZE LIVE
- Output: GoodPrizeLive.apk
- Landscape
- ARM64
- IL2CPP
- Release

Before Build:
1. Open this UnityProject in Unity Hub/Unity Editor.
2. Install Android Build Support, Android SDK & NDK Tools and OpenJDK.
3. Switch platform to Android.
4. Set Package Name to a unique ID such as:
   com.goodprizelive.cricket
5. Set ARM64 architecture.
6. Set IL2CPP scripting backend.
7. Set Landscape orientation.
8. Add the actual game scenes to Build Settings.
9. Resolve any missing 3D/audio assets and script references.
10. Build and verify GoodPrizeLive.apk on an Android device.

IMPORTANT:
The uploaded Final ZIP does not contain a Unity Editor, Android SDK/NDK,
compiled APK, or a complete production 3D asset library. Therefore this
package is the maximum APK-build preparation that can honestly be completed
in this environment; it is not itself an installable APK.
