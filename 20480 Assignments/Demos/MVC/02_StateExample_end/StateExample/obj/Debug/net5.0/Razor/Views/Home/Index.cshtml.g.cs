#pragma checksum "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fc8f261125fffed33c056b38c17abe0c5a7e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7fc8f261125fffed33c056b38c17abe0c5a7e88", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dab4f0d6921901266c6976cdaf8612ba44eb13", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"info-panel\">\n    <div>Number of times that the Home controller was visited during this session:");
#nullable restore
#line 8 "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                                             Write(Context.Session.GetInt32("Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div>Number of times that the Another controller was visited during this session: ");
#nullable restore
#line 9 "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                                                 Write(Context.Session.GetInt32("Another"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div>Number of times visited overall during this session: ");
#nullable restore
#line 10 "C:\Users\Bossman\Desktop\Assigments\MSSA-Assignments\20480 Assignments\Demos\MVC\02_StateExample_end\StateExample\Views\Home\Index.cshtml"
                                                         Write(Context.Session.GetInt32("Overall"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
