#pragma checksum "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fc8f261125fffed33c056b38c17abe0c5a7e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7fc8f261125fffed33c056b38c17abe0c5a7e88", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dab4f0d6921901266c6976cdaf8612ba44eb13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Home";

#line default
#line hidden
            BeginContext(80, 108, true);
            WriteLiteral("\n<div class=\"info-panel\">\n    <div>Number of times that the Home controller was visited during this session:");
            EndContext();
            BeginContext(189, 32, false);
#line 8 "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                                             Write(Context.Session.GetInt32("Home"));

#line default
#line hidden
            EndContext();
            BeginContext(221, 93, true);
            WriteLiteral("</div>\n    <div>Number of times that the Another controller was visited during this session: ");
            EndContext();
            BeginContext(315, 35, false);
#line 9 "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                                                 Write(Context.Session.GetInt32("Another"));

#line default
#line hidden
            EndContext();
            BeginContext(350, 69, true);
            WriteLiteral("</div>\n    <div>Number of times visited overall during this session: ");
            EndContext();
            BeginContext(420, 35, false);
#line 10 "C:\Deepali\20486D-DevelopingASPNETMVCWebApplications-master\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod12\Democode\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                         Write(Context.Session.GetInt32("Overall"));

#line default
#line hidden
            EndContext();
            BeginContext(455, 14, true);
            WriteLiteral("</div>\n</div>\n");
            EndContext();
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
