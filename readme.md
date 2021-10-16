# Cross platform with Blazor

**This demo shows how Blazor (using only official .NET 6 APIs) running in both the web browser and WinForms wrapper.**
This uses the default Blazor Server template from .NET 6 as an example.

---

#### Description

All code shared between Blazor Desktop and Blazor Server apps is in the ```BlazorClassLibrary``` Razor class library. To switch between projects assign a necessary project as the main one (starting).

#### Demonstration

![apps](/apps.gif "Apps demo")

Because you have now achieved the power of Chromium you can launch high-performance interactive 2D/3D ***[WebGL]*** graphics even directly inside your desktop apps such as Windows Forms.

![webgl](/webgl.gif "WebGL water demo")

To run it open ```/BlazorCrossPlatform.sln``` in Visual Studio 2022 Preview 4 with the .NET 6 RC1 SDK installed and "Enable Preview .NET SDKs" turned on.

*Special thanks to [Ed Andersen] for Blazor kungfu techniques and [Evan Wallace] for incredible [WebGL] water demo.*

[Ed Andersen]: https://github.com/edandersen (Ed Andersen's GitHub)
[Evan Wallace]: https://github.com/evanw (Evan Wallace's GitHub)
[WebGL]: https://www.khronos.org/webgl (official WebGL website)