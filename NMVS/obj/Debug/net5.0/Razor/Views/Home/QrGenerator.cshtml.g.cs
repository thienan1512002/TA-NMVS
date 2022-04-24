#pragma checksum "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\Home\QrGenerator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415207b06f43a8130ad7dd6861b736419980d43c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QrGenerator), @"mvc.1.0.view", @"/Views/Home/QrGenerator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415207b06f43a8130ad7dd6861b736419980d43c", @"/Views/Home/QrGenerator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d832c166946ffcb93de6100ef6869aaae39154d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_QrGenerator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/qr/qrcode.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\Home\QrGenerator.cshtml"
  
    ViewData["Title"] = "QR code Generator";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415207b06f43a8130ad7dd6861b736419980d43c3711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row mt-4\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            <!-- Card header -->\r\n            <div class=\"card-header\">\r\n                <h3 class=\"mb-0\">");
#nullable restore
#line 11 "C:\Users\nhta1\OneDrive\Documents\TA-NMVS\NMVS\Views\Home\QrGenerator.cshtml"
                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""card-body"">
                <div class=""form-group row col-md-6"">
                    <span class=""col-md-9"">
                        <label class=""form-label"" for=""code-side"">File (*.csv)</label>
                        <input type=""file"" id=""file-form"" class=""form-control"" accept="".csv"" />
                    </span>
                    <span class=""col-md-3"">
                        <label class=""form-label"" for=""code-side"">Code size (px)</label>
                        <input type=""number"" class=""form-control"" value=""250"" id=""code-size""
                            placeholder=""Code size (px)"" />
                    </span>

                </div>
                <div class=""form-group  col-md-6"">

                </div>
                <div class=""form-group col-md-6"">
                    <button class=""btn btn-primary"" id=""generate-qr-code"">
                        Generate code
                    </button>
                </div>
  ");
            WriteLiteral(@"              <div>
                    <table class=""table table-bordered col-12"" id=""qr-table"">
                        <thead>
                            <th>
                                Item code
                            </th>
                            <th>
                                QR code
                            </th>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('#generate-qr-code').on('click', function () {
            var files = document.getElementById('file-form').files;
            if (files.length > 0) {
                processData(files[0]);
            } else {
                alert('no file choosen!');
            }



        })
    });

    function processData(allText) {

        var formData = new FormData();
        formData");
            WriteLiteral(@".append('files',allText);
        $.ajax({
            url: apiUrl + ""/api/IncomingList/QrListExtract"",
            data: formData,
            processData: false,
            contentType: false,
            type: ""POST"",
            success: function (ls) {
                var i = 0;
                $.each(ls, function (index, value) {
                    i++;
                    var row = value.split(',');
                    if(row.length == 2){
                        printCode('qr'+i, row[1], row[0]);
                    }else{
                        printCode('qr'+i, '', row[0]);
                    }
                });
            }

        });
    }

    function printCode(id, name, txt) {
        var newRowContent = `<tr><td>` + name + `</td> <td> <div id=""` + id + `""> </div> </td></tr>`;
        $(""#qr-table tbody"").append(newRowContent);

        $('#' + id).css({
            'width': $('#code-size').val(),
            'height': $('#code-size').val()
        })

 ");
            WriteLiteral("       // Generate and Output QR Code\r\n        $(\'#\' + id).qrcode({\r\n            width: $(\'#code-size\').val(),\r\n            height: $(\'#code-size\').val(),\r\n            text: txt\r\n        });\r\n    }\r\n</script>");
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