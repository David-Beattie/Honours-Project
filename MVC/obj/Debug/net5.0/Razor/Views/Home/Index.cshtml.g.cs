#pragma checksum "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "783d13b8da4595aec68c0aced354c264f6f7c370"
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
#line 1 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783d13b8da4595aec68c0aced354c264f6f7c370", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <h2>Glasgow rocks wheelchair basketball Players</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
    
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 13 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
      Write(item.PlayerID);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 13 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
                      Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
                                      Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Age: ");
#nullable restore
#line 13 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
                                                          Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\David\OneDrive\Desktop\Hons project\Project\MVC\Views\Home\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
