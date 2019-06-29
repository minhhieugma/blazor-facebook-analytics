using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.Facebook.Analytics.Components
{
    public class FacebookPixelComponent : ComponentBase, IDisposable
    {
        public const string Configure = "FacebookAnalyticsInterop.configure";


        [Parameter]
        protected string AppId { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        protected override async Task OnInitAsync()
        {
            base.OnInit();

        }

        protected override async Task OnAfterRenderAsync()
        {
            await JSRuntime.InvokeAsync<string>(Configure, AppId);

            await base.OnAfterRenderAsync();
        }

        public void Dispose()
        {
            
        }
    }
}
