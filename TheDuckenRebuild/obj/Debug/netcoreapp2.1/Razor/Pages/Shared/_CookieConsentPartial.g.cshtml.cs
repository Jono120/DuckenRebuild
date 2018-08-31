#pragma checksum "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1dc408006db1dd9160faa645eaffe84e4aac29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TheDuckenRebuild.Pages.Shared.Pages_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_CookieConsentPartial.cshtml", typeof(TheDuckenRebuild.Pages.Shared.Pages_Shared__CookieConsentPartial))]
namespace TheDuckenRebuild.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\_ViewImports.cshtml"
using TheDuckenRebuild;

#line default
#line hidden
#line 1 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1dc408006db1dd9160faa645eaffe84e4aac29", @"/Pages/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a06e5798744a43fb8734ffd50e38304d0da27eb6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml"
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
            BeginContext(248, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml"
 if (showBanner)
{

#line default
#line hidden
            BeginContext(271, 1128, true);
            WriteLiteral(@"    <nav id=""cookieConsent"" class=""navbar navbar-default navbar-fixed-top"" role=""alert"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#cookieConsent .navbar-collapse"">
                    <span class=""sr-only"">Toggle cookie consent banner</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <span class=""navbar-brand""><span class=""glyphicon glyphicon-info-sign"" aria-hidden=""true""></span></span>
            </div>
            <div class=""collapse navbar-collapse"">
                <p class=""navbar-text"">
                    This site, like others within the Internet, uses small files that are called cookies to be able customise your experiences within our site.<br />
                    You can find out more about the cookies that ");
            WriteLiteral("we use and how you can control them.\r\n                </p>\r\n                <div class=\"navbar-right\">\r\n");
            EndContext();
            BeginContext(1494, 97, true);
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-default navbar-btn\" data-cookie-string=\"");
            EndContext();
            BeginContext(1592, 12, false);
#line 29 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml"
                                                                                            Write(cookieString);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 455, true);
            WriteLiteral(@""">Close</button>
                </div>
            </div>
        </div>
    </nav>
    <script>
        (function () {
            document.querySelector(""#cookieConsent button[data-cookie-string]"").addEventListener(""click"", function (el) {
                document.cookie = el.target.dataset.cookieString;
                document.querySelector(""#cookieConsent"").classList.add(""hidden"");
            }, false);
        })();
    </script>
");
            EndContext();
#line 42 "C:\Users\lakejo\Source\Repos\DuckenRebuild\TheDuckenRebuild\Pages\Shared\_CookieConsentPartial.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
