#pragma checksum "/Users/cagdashasturk/Projects/JobFinder/JobFinder.MvcWebUI/Views/Sector/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80223034e09cd5ee82add1987c266ab85aaec24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sector_Index), @"mvc.1.0.view", @"/Views/Sector/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80223034e09cd5ee82add1987c266ab85aaec24", @"/Views/Sector/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Sector_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobFinder.MvcWebUI.Models.SectorListModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Sector List</h2>\n<table class=\"table-class\">\n    <thead>\n        <tr>\n            <th>Sector ID</th>\n            <th>Sector Name</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 12 "/Users/cagdashasturk/Projects/JobFinder/JobFinder.MvcWebUI/Views/Sector/Index.cshtml"
         foreach (var sector in Model.Sectors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 15 "/Users/cagdashasturk/Projects/JobFinder/JobFinder.MvcWebUI/Views/Sector/Index.cshtml"
               Write(sector.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 16 "/Users/cagdashasturk/Projects/JobFinder/JobFinder.MvcWebUI/Views/Sector/Index.cshtml"
               Write(sector.SectorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 18 "/Users/cagdashasturk/Projects/JobFinder/JobFinder.MvcWebUI/Views/Sector/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobFinder.MvcWebUI.Models.SectorListModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591