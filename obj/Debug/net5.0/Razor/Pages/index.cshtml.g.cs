#pragma checksum "C:\Users\Vuk\Desktop\Moji projekti\4fit\Aplikacija\Pages\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97c6ca278bfe6399e0aa51a34ba816e779c50e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_index), @"mvc.1.0.razor-page", @"/Pages/index.cshtml")]
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
#line 2 "C:\Users\Vuk\Desktop\Moji projekti\4fit\Aplikacija\Pages\index.cshtml"
using _4fit.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97c6ca278bfe6399e0aa51a34ba816e779c50e1", @"/Pages/index.cshtml")]
    #nullable restore
    public class Pages_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Vuk\Desktop\Moji projekti\4fit\Aplikacija\Pages\index.cshtml"
     
    Layout = "_Layout";
    ViewData["Title"] = "4fit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("OpcijeHeder", async() => {
                WriteLiteral(@"
    
 
<div class=""collapse navbar-collapse udalji"" id=""navbarResponsive"">
    <ul class=""navbar-nav marginaLevo"">
        <li class=""nav-item active crtajPocetnu pointer""><a class=""nav-link selected aPocetna"">Pocetna strana</a></li>
        <li class=""nav-item crtajForum pointer""><a class=""nav-link aForum"">Forum</a></li>
        <li class=""nav-item crtajPodrsku pointer""><a class=""nav-link aONama"">Podrska</a></li>
        
    </ul>

    <!-- <button class=""btnHederPrijaviSe"">Prijavi se plssss</button> -->

    <ul class=""nav navbar-nav navbar-right"">
    <li class=""nav-item btnHederPrijaviSe pointer""><a class=""nav-link"">Prijavi se</a></li>
    <li class=""nav-item btnHederRegistrujSe pointer""><a class=""nav-link"">Registruj se</a></li>

</ul>
</div>

");
            }
            );
            WriteLiteral("\n");
            DefineSection("Script", async() => {
                WriteLiteral("\n");
                WriteLiteral("        <script src=\"source/main.js\" type=\"module\"></script>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<indexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<indexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<indexModel>)PageContext?.ViewData;
        public indexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
