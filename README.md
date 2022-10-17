# RecreateMauiIssue
This repo is for recreating an issue that the window width equals to -1 in the OnLoaded event in a Maui project when running on Android

### Recreate the issue: 
Run it in Android and it will throw an exception because the page width is -1. It works fine if running on Windows. 

### More info: 
I can get the correct Width/Height in OnSizeChanged events. Also I found OnSizeChanged event was raised before OnLoaded on Windows, but after OnLoaded on Android, that's probably why it is correct on Windows but incorrect on Android.
