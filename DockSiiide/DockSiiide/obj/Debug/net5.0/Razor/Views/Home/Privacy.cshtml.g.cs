#pragma checksum "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d46679263349f7148fef4e40d153f727d4409c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\_ViewImports.cshtml"
using DockSiiide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\_ViewImports.cshtml"
using DockSiiide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
using DockSiiide.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d46679263349f7148fef4e40d153f727d4409c3", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a48ed09c15a6feee2522af85ec55ad12be120a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 12 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
 if (SignInManager.IsSignedIn(User) && await UserManager.IsInRoleAsync(UserManager.GetUserAsync(User).Result, "admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>HOLE SHIT THIS IS AN ADMIN</h1>\r\n");
#nullable restore
#line 17 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>SAD FACE, Not an admin :(</h1>\r\n");
#nullable restore
#line 21 "C:\Users\Victor\source\repos\DockSiiide\DockSiiide\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Use this page to detail your site\'s privacy policy.</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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
