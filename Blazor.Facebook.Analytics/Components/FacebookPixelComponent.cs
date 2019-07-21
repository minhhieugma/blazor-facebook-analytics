using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Blazor.Facebook.Analytics.Components
{
    public class FacebookPixelComponent : ComponentBase, IDisposable
    {
        [Parameter]
        protected string AppId { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            var script = @"<script>
              !function(f,b,e,v,n,t,s)
              {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
              n.callMethod.apply(n,arguments):n.queue.push(arguments)};
              if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
              n.queue=[];t=b.createElement(e);t.async=!0;
              t.src=v;s=b.getElementsByTagName(e)[0];
              s.parentNode.insertBefore(t,s)}(window, document,'script',
              'https://connect.facebook.net/en_US/fbevents.js');
              fbq('init', '" + this.AppId + @"');
              fbq('track', 'PageView');
            </script>";

            builder.AddMarkupContent(0, script);
            builder.AddMarkupContent(1, @"<script src=""_content/Blazor-Facebook-Analytics/interop.js""></script>");
        }

        public void Dispose()
        {

        }
    }
}
