#pragma checksum "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84100140e0a6175078cc36e52288104d858e8afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Index.cshtml", typeof(AspNetCore.Views_Test_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84100140e0a6175078cc36e52288104d858e8afb", @"/Views/Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8c63dad9db0b17e31c66667dec1a52add46bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.TestViewModels.ArticleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(185, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(192, 16, false);
#line 13 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(208, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(216, 47, false);
#line 14 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
Write(Html.Partial("AuthorPartial", Model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(263, 5, true);
            WriteLiteral(";\r\n\r\n");
            EndContext();
#line 16 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
 foreach (var section in @Model.Sections)
{
    

#line default
#line hidden
            BeginContext(319, 39, false);
#line 18 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
Write(Html.Partial("ArticleSection", section));

#line default
#line hidden
            EndContext();
#line 18 "C:\0WorkBench\1-code\5-StackOverFlow\ASP.NET-Core-MVC-with-EF-Core---tutorial-series\ContosoUniversity\Views\Test\Index.cshtml"
                                            ;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.TestViewModels.ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591