#pragma checksum "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3517cf58ca547384da21b93b91715a5941cfbdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummery_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummery/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummery/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummery_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3517cf58ca547384da21b93b91715a5941cfbdb", @"/Views/Shared/Components/CartSummery/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b791dc17b6b423a1c1a7967b92347b0b78a700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummery_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcWebUI.Models.CartSummeryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 4 "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml"
 foreach (var item in Model.Cart.CartLines)
{

#line default
#line hidden
            BeginContext(106, 38, true);
            WriteLiteral("    <a class=\"dropdown-item\">\n        ");
            EndContext();
            BeginContext(145, 24, false);
#line 7 "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml"
   Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(169, 35, true);
            WriteLiteral(" <span class=\"badge badge-warning\">");
            EndContext();
            BeginContext(205, 13, false);
#line 7 "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml"
                                                               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(218, 17, true);
            WriteLiteral("</span>\n    </a>\n");
            EndContext();
#line 9 "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml"
}

#line default
#line hidden
            BeginContext(237, 104, true);
            WriteLiteral("<div class=\"dropdown-divider\"></div>\n    <a class=\"dropdown-item\">\n        <span class=\"\"></span>Total: ");
            EndContext();
            BeginContext(342, 16, false);
#line 12 "/home/isa/RiderProjects/Abc/Abc.Northwind.MvcWebUI/Views/Shared/Components/CartSummery/Default.cshtml"
                                Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("</a>\n\n<div class=\"dropdown-divider\"></div>\n");
            EndContext();
            BeginContext(401, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3517cf58ca547384da21b93b91715a5941cfbdb5888", async() => {
                BeginContext(466, 18, true);
                WriteLiteral("Go To Cart Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcWebUI.Models.CartSummeryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
