#pragma checksum "/Users/Guest/Desktop/Shrooms.Solution/Shrooms.MVC/Views/Mushrooms/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f23f2d5c6eea69cf6b5ca3d51fef256ac05986b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mushrooms_Index), @"mvc.1.0.view", @"/Views/Mushrooms/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mushrooms/Index.cshtml", typeof(AspNetCore.Views_Mushrooms_Index))]
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
#line 1 "/Users/Guest/Desktop/Shrooms.Solution/Shrooms.MVC/Views/Mushrooms/Index.cshtml"
using Shrooms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f23f2d5c6eea69cf6b5ca3d51fef256ac05986b", @"/Views/Mushrooms/Index.cshtml")]
    public class Views_Mushrooms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/Shrooms.Solution/Shrooms.MVC/Views/Mushrooms/Index.cshtml"
 foreach (Mushroom mushroom in Model)
{

#line default
#line hidden
            BeginContext(64, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(72, 92, false);
#line 5 "/Users/Guest/Desktop/Shrooms.Solution/Shrooms.MVC/Views/Mushrooms/Index.cshtml"
  Write(Html.ActionLink($"{@mushroom.Name}", "Details", "Mushrooms", new {id = mushroom.MushroomId}));

#line default
#line hidden
            EndContext();
            BeginContext(164, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Shrooms.Solution/Shrooms.MVC/Views/Mushrooms/Index.cshtml"
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
