#pragma checksum "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd14b7dcf3d06bdbbf4c2749a3830abe7b6457b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Men), @"mvc.1.0.view", @"/Views/Home/Men.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Men.cshtml", typeof(AspNetCore.Views_Home_Men))]
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
#line 1 "D:\C#4\Assignment\Assignment\Assignment\Views\_ViewImports.cshtml"
using Assignment;

#line default
#line hidden
#line 2 "D:\C#4\Assignment\Assignment\Assignment\Views\_ViewImports.cshtml"
using Assignment.Models;

#line default
#line hidden
#line 4 "D:\C#4\Assignment\Assignment\Assignment\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd14b7dcf3d06bdbbf4c2749a3830abe7b6457b2", @"/Views/Home/Men.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3cc8d4f92aa0394bc6a3baeaf321c49a82c706", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Men : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(79, 59, true);
            WriteLiteral("<div class=\"cont span_2_of_3\">\r\n    <div class=\"top-box\">\r\n");
            EndContext();
#line 7 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(187, 66, true);
            WriteLiteral("            <div class=\"col_1_of_3 span_1_of_3\">\r\n                ");
            EndContext();
            BeginContext(253, 948, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd14b7dcf3d06bdbbf4c2749a3830abe7b6457b24111", async() => {
                BeginContext(303, 145, true);
                WriteLiteral("\r\n                    <div class=\"inner_content clearfix\">\r\n                        <div class=\"product_image\">\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 448, "\"", 464, 1);
#line 13 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
WriteAttributeValue("", 454, item.Hinh, 454, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(465, 281, true);
                WriteLiteral(@" />
                        </div>
                        <div class=""sale-box""><span class=""on_sale title_shop"">New</span></div>
                        <div class=""price"">
                            <div class=""cart-left"">
                                <p class=""title"">");
                EndContext();
                BeginContext(747, 10, false);
#line 18 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
                                            Write(item.TenSp);

#line default
#line hidden
                EndContext();
                BeginContext(757, 117, true);
                WriteLiteral("</p>\r\n                                <div class=\"price1\">\r\n                                    <span class=\"actual\">");
                EndContext();
                BeginContext(875, 41, false);
#line 20 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
                                                    Write(item.Gia.ToString("n0").Replace(',', '.'));

#line default
#line hidden
                EndContext();
                BeginContext(916, 281, true);
                WriteLiteral(@" VNĐ</span>
                                </div>
                            </div>
                            <div class=""cart-right""> </div>
                            <div class=""clear""></div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
                                          WriteLiteral(item.MaSp);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1201, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 29 "D:\C#4\Assignment\Assignment\Assignment\Views\Home\Men.cshtml"
        }

#line default
#line hidden
            BeginContext(1234, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
