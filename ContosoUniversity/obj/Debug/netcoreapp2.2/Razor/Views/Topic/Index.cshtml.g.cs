#pragma checksum "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0fb5ed06eb48e2bbf3269006f5fdbc02b142aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Index), @"mvc.1.0.view", @"/Views/Topic/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Topic/Index.cshtml", typeof(AspNetCore.Views_Topic_Index))]
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
#line 1 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0fb5ed06eb48e2bbf3269006f5fdbc02b142aac", @"/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.ViewModel.TopicsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 30, true);
            WriteLiteral("\r\n<h1>Topics</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(132, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fb5ed06eb48e2bbf3269006f5fdbc02b142aac4334", async() => {
                BeginContext(160, 10, true);
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
            BeginContext(174, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(267, 67, false);
#line 16 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().TopicId));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 65, false);
#line 19 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().Title));

#line default
#line hidden
            EndContext();
            BeginContext(455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(511, 74, false);
#line 22 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().OriginalPoster));

#line default
#line hidden
            EndContext();
            BeginContext(585, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(641, 69, false);
#line 25 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().PostCount));

#line default
#line hidden
            EndContext();
            BeginContext(710, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
         foreach (var item in Model.Topics)
        {

#line default
#line hidden
            BeginContext(852, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(925, 42, false);
#line 35 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TopicId));

#line default
#line hidden
            EndContext();
            BeginContext(967, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1047, 40, false);
#line 38 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1167, 49, false);
#line 41 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OriginalPoster));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1296, 44, false);
#line 44 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PostCount));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1419, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0fb5ed06eb48e2bbf3269006f5fdbc02b142aac10220", async() => {
                BeginContext(1475, 11, true);
                WriteLiteral("Create Post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                                                     WriteLiteral(item.TopicId);

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
            BeginContext(1490, 124, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1615, 89, false);
#line 52 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().Posts.FirstOrDefault().Poster));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1784, 87, false);
#line 55 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().Posts.FirstOrDefault().Body));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1951, 92, false);
#line 58 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Topics.FirstOrDefault().Posts.FirstOrDefault().TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 52, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
            EndContext();
#line 61 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                foreach (var itemPosts in item.Posts)
                {

#line default
#line hidden
            BeginContext(2169, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2254, 46, false);
#line 65 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => itemPosts.Poster));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2392, 44, false);
#line 68 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => itemPosts.Body));

#line default
#line hidden
            EndContext();
            BeginContext(2436, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2528, 49, false);
#line 71 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => itemPosts.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 74 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Topic\Index.cshtml"
                }
        }

#line default
#line hidden
            BeginContext(2667, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.ViewModel.TopicsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
