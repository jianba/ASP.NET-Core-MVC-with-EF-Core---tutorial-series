#pragma checksum "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be78cd7c40c30e5cc2587fb69845d9e91ebca39c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be78cd7c40c30e5cc2587fb69845d9e91ebca39c", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.OrderViewModels.OrdersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 30, true);
            WriteLiteral("\r\n<h1>Topics</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be78cd7c40c30e5cc2587fb69845d9e91ebca39c3979", async() => {
                BeginContext(166, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(273, 67, false);
#line 16 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(340, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(396, 73, false);
#line 19 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().PickUpAddress));

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(525, 74, false);
#line 22 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().DropOffAddress));

#line default
#line hidden
            EndContext();
            BeginContext(599, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
         foreach (var item in Model.Orders)
        {

#line default
#line hidden
            BeginContext(741, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(802, 42, false);
#line 32 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(844, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(912, 48, false);
#line 35 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PickUpAddress));

#line default
#line hidden
            EndContext();
            BeginContext(960, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1028, 49, false);
#line 38 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DropOffAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 154, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n\r\n                <th>\r\n                    <font color=\"#FF0000\">\r\n                        ");
            EndContext();
            BeginContext(1232, 91, false);
#line 45 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().Cargos.FirstOrDefault().OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 144, true);
            WriteLiteral("\r\n                    </font>\r\n                </th>\r\n                <th>\r\n                    <font color=\"#FF0000\">\r\n                        ");
            EndContext();
            BeginContext(1468, 90, false);
#line 50 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().Cargos.FirstOrDefault().Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 144, true);
            WriteLiteral("\r\n                    </font>\r\n                </th>\r\n                <th>\r\n                    <font color=\"#FF0000\">\r\n                        ");
            EndContext();
            BeginContext(1703, 93, false);
#line 55 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Orders.FirstOrDefault().Cargos.FirstOrDefault().CargoType));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 73, true);
            WriteLiteral("\r\n                    </font>\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 59 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
            foreach (var itemCargos in item.Cargos)
            {

#line default
#line hidden
            BeginContext(1937, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2010, 48, false);
#line 63 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => itemCargos.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2138, 47, false);
#line 66 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => itemCargos.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2265, 50, false);
#line 69 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => itemCargos.CargoType));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 72 "D:\catch\StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Order\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2393, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.OrderViewModels.OrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
