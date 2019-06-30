
namespace FacebookAnalyticsInterop {

    export function configure(appId: string): void {
        const code = document.createTextNode(
            "!function(e,t,n,c,o,a,f){e.fbq||(o=e.fbq=function(){o.callMethod?o.callMethod.apply(o,arguments):o.queue.push(arguments)},e._fbq||(e._fbq=o),o.push=o,o.loaded=!0,o.version='2.0',o.queue=[],(a=t.createElement(n)).async=!0,a.src='https://connect.facebook.net/en_US/fbevents.js',(f=t.getElementsByTagName(n)[0]).parentNode.insertBefore(a,f))}(window,document,'script'),fbq('init','" + appId + "'),fbq('track','PageView');"
        );

        const bodyScript = document.createElement("script");
        bodyScript.appendChild(code);
        document.body.appendChild(bodyScript);
    }

    export function navigate(appId: string, href: string): void {
        //console.log(`[Facebook Pixel][${appId}] Navigated: ${href}`);
    }
}