#pragma checksum "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62cd0f1ceaba4adf3e3902b6396b22328c387cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#line 2 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62cd0f1ceaba4adf3e3902b6396b22328c387cd", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84358f87b42b29a4fca716d45eea24deed850c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SportsStore.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
  
 ViewBag.Title = "Orders";
 Layout = "_AdminLayout";

#line default
#line hidden
#line 6 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
 if (Model.Count() > 0) {

#line default
#line hidden
            BeginContext(135, 127, true);
            WriteLiteral(" <table class=\"table table-bordered table-striped\">\r\n <tr><th>Name</th><th>Zip</th><th colspan=\"2\">Details</th><th></th></tr>\r\n");
            EndContext();
#line 9 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
  foreach (SportsStore.Models.Order o in Model) {

#line default
#line hidden
            BeginContext(313, 12, true);
            WriteLiteral(" <tr>\r\n <td>");
            EndContext();
            BeginContext(326, 6, false);
#line 11 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
Write(o.Name);

#line default
#line hidden
            EndContext();
            BeginContext(332, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(342, 5, false);
#line 11 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
                Write(o.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(347, 58, true);
            WriteLiteral("</td><th>Product</th><th>Quantity</th>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(405, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f62cd0f1ceaba4adf3e3902b6396b22328c387cd6349", async() => {
                BeginContext(450, 49, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"orderId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 499, "\"", 517, 1);
#line 14 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
WriteAttributeValue("", 507, o.OrderID, 507, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(518, 124, true);
                WriteLiteral(" />\r\n            <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                Ship\r\n            </button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(649, 21, true);
            WriteLiteral("\r\n    </td>\r\n </tr>\r\n");
            EndContext();
#line 21 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
  foreach (SportsStore.Models.CartLine line in o.Lines) {

#line default
#line hidden
            BeginContext(729, 44, true);
            WriteLiteral(" <tr>\r\n     <td colspan=\"2\"></td>\r\n     <td>");
            EndContext();
            BeginContext(774, 17, false);
#line 24 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
    Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(791, 16, true);
            WriteLiteral("</td>\r\n     <td>");
            EndContext();
            BeginContext(808, 13, false);
#line 25 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
    Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(821, 31, true);
            WriteLiteral("</td>\r\n     <td></td>\r\n </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
 }

#line default
#line hidden
#line 28 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
  
 }

#line default
#line hidden
            BeginContext(860, 11, true);
            WriteLiteral(" </table>\r\n");
            EndContext();
#line 31 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
} else {

#line default
#line hidden
            BeginContext(881, 53, true);
            WriteLiteral(" <div class=\"text-center\">No Unshipped Orders</div>\r\n");
            EndContext();
#line 33 "C:\Users\Pierre\Desktop\Dossier études 2014 -\Dossier Paul Lambin\BLOC 3 2019 - 2020\Cours\Quadrimestre 1\ASP.NET\S3\SportsStore\SportsStore\Views\Order\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SportsStore.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591