using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.Facebook.Analytics
{
    public class FacebookPixelComponent : ComponentBase, IDisposable
    {
        [Parameter]
        public string AppId { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = null;

        [Inject]
        protected IJSRuntime JSRuntime { get; set; } = null;

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            //var script = @"<script>
            //  !function(f,b,e,v,n,t,s)
            //  {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
            //  n.callMethod.apply(n,arguments):n.queue.push(arguments)};
            //  if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
            //  n.queue=[];t=b.createElement(e);t.async=!0;
            //  t.src=v;s=b.getElementsByTagName(e)[0];
            //  s.parentNode.insertBefore(t,s)}(window, document,'script',
            //  'https://connect.facebook.net/en_US/fbevents.js');
            //  fbq('init', '" + AppId + @"');
            //  fbq('track', 'PageView');
            //</script>";

            //builder.AddMarkupContent(0, script);
            //builder.AddMarkupContent(1, @"<script src=""_content/Blazor-Facebook-Analytics/interop.js""></script>");
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            NavigationManager.LocationChanged -= OnLocationChanged;
            NavigationManager.LocationChanged += OnLocationChanged;

          
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeAsync<string>("FacebookAnalyticsInterop.initialize", AppId);
            }
            //return base.OnAfterRenderAsync(firstRender);
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;

        }

        private async void OnLocationChanged(object sender,  Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
        {
            //var relativeUri = new Uri(args.Location).PathAndQuery;

            //await JSRuntime.InvokeAsync<string>(GoogleAnalyticsInterop.Navigate,
            //    TrackingId, relativeUri);
        }
    }
}
