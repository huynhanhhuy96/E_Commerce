#pragma checksum "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab6a20778c912545606490e51edc0d16c2a7317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.UI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace EC.UI.Pages
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
#line 1 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\_ViewImports.cshtml"
using EC.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab6a20778c912545606490e51edc0d16c2a7317", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac37f356421df91d4dbafe8604f6e4639cf7a42", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
  
    ViewData["Title"] = "All Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- View Title -->\r\n<h4 class=\"ml-3 mt-2\">");
#nullable restore
#line 7 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <table class=\'table\'>\r\n            <thead");
            BeginWriteAttribute("class", " class=\'", 240, "\'", 248, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <tr>\r\n                    <th>Id</th>\r\n                    <th>Title</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 18 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
                 foreach (var item in Model.lst)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
