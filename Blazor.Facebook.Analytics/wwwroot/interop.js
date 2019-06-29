var FacebookAnalyticsInterop;
(function (FacebookAnalyticsInterop) {
    function configure(appId) {
        var appVersion = "v3.3";
        var bodyScript = document.createElement("script");
        var code = document.createTextNode("window.fbAsyncInit = function () {" +
            "    FB.init({" +
            "        appId: '" + appId + "'," +
            "        cookie: true," +
            "        xfbml: true," +
            "        version: '" + appVersion + "'" +
            "    });" +
            "" +
            "    FB.AppEvents.logPageView();" +
            "" +
            "};" +
            "(function (d, s, id) {" +
            "    var js, fjs = d.getElementsByTagName(s)[0];" +
            "    if (d.getElementById(id)) { return; }" +
            "    js = d.createElement(s); js.id = id;" +
            "    js.src = 'https://connect.facebook.net/en_US/sdk.js';" +
            "    fjs.parentNode.insertBefore(js, fjs);" +
            "}(document, 'script', 'facebook-jssdk'));");
        bodyScript.appendChild(code);
        document.body.appendChild(bodyScript);
    }
    FacebookAnalyticsInterop.configure = configure;
})(FacebookAnalyticsInterop || (FacebookAnalyticsInterop = {}));
