#pragma checksum "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\Documents\_ProgressbarWbutton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1a4eacc2e5c01f61b23e786d1a444e27c5d7cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Documents__ProgressbarWbutton), @"mvc.1.0.view", @"/Views/Documents/_ProgressbarWbutton.cshtml")]
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
#line 1 "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\_ViewImports.cshtml"
using NMVS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\_ViewImports.cshtml"
using NMVS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1a4eacc2e5c01f61b23e786d1a444e27c5d7cd", @"/Views/Documents/_ProgressbarWbutton.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d832c166946ffcb93de6100ef6869aaae39154d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Documents__ProgressbarWbutton : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""progress"" style=""height: 30px;"">
    <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""font-weight: bold; font-size: 15px; height: 100%;"" role=""progressbar"" aria-valuemin=""0"" aria-valuemax=""100""></div>
</div>
<div>
    <button class=""action back btn btn-outline-warning"" style=""display: none"">Back</button>
    <button class=""action next btn btn-outline-primary float-end"">Next</button>
</div>");
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
