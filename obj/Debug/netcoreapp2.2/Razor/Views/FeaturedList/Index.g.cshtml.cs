#pragma checksum "/home/kodibear/development/c/movieMvc/Views/FeaturedList/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9befba8bb6522faf597c75805103922a6ca9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeaturedList_Index), @"mvc.1.0.view", @"/Views/FeaturedList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FeaturedList/Index.cshtml", typeof(AspNetCore.Views_FeaturedList_Index))]
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
#line 1 "/home/kodibear/development/c/movieMvc/Views/_ViewImports.cshtml"
using movieMvc;

#line default
#line hidden
#line 2 "/home/kodibear/development/c/movieMvc/Views/_ViewImports.cshtml"
using movieMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9befba8bb6522faf597c75805103922a6ca9b5", @"/Views/FeaturedList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22924b993e19da331b610274050618f3438220fc", @"/Views/_ViewImports.cshtml")]
    public class Views_FeaturedList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/kodibear/development/c/movieMvc/Views/FeaturedList/Index.cshtml"
  
    ViewData["Title"] = "Movie List";

#line default
#line hidden
            BeginContext(43, 810, true);
            WriteLiteral(@"<h2>The Top Movies of 2018</h2>
<img style=""height: 10vh; width: 10vh;"" src=""http://www.filmtraining.mb.ca/wp-content/uploads/2014/02/clap.png""/>
<p>Here we will list and discuss the top films of 2018. <br><br>2018 was quite a year for film; one of my favorites in 2018 was the psychologial and supernatural thriller ""Hereditary"". </p>
<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/V6wWKNij_1M"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
<p>Hereditary follows the story of a family dealing with the death of their estranged and mentally ill grandmother. Things begin to accelerate repidly as a tragedy strikes after the funeral and the family begins to mentally and physically unravel. Highly recommended.</p>");
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
