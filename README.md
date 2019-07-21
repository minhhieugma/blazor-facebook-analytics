Blazor component for Blazor Facebook Pixel - Analytics.
Supported platforms: Facebook Pixel, Facebook Analytics, ...

Blazor Version: 3.0.0-preview6.19307.2

# NuGet Package
https://nuget.org/packages/Blazor-Facebook-Analytics

### Server Side Rendering
The Facebook Pixel will be added at Server Side Rendering time so that there is no latency time 

# Configuration

### Facebook Pixcel, App Id

Add the `FacebookPixelComponent` component below your Router in `App.razor`.

```
<Router AppAssembly="typeof(App).Assembly" />
<Blazor.Facebook.Analytics.Components.FacebookPixelComponent AppId="1234567890123456" />
```
Get your App Id(`AppId`) from Facebook Devevloper page

