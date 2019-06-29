Blazor component for Blazor Facebook Pixel - Analytics.
Supported platforms: Facebook Pixel, Facebook Analytics, ...

Blazor Version: 3.0.0-preview6.19307.2

# NuGet Package
https://nuget.org/packages/Blazor-Facebook-Analytics

# Configuration

### Facebook Pixcel, App Id

Add the `FacebookPixelComponent` component below your Router in `App.razor`.

```
<Router AppAssembly="typeof(App).Assembly" />
<Blazor.Facebook.Analytics.Components.FacebookPixelComponent AppId="1234567890123456" />
```
Get your App Id(`AppId`) from Facebook Devevloper page

### Blazor Server Side Rendering Project
At least for `3.0.0-preview6.19307.2`, We need to manually add scrips to `head` tag:
```
<environment include="Development">
    <link rel="stylesheet" href="css/bootstrap/bootstrap.min.css" />
    <script src="_content/Blazor-Facebook-Analytics/interop.js"></script>
</environment>
```
https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-6/