#pragma checksum "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c80300763a52626e9a849f57674cf31e2799cb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EC.UI.Pages.Pages_Products), @"mvc.1.0.razor-page", @"/Pages/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c80300763a52626e9a849f57674cf31e2799cb4", @"/Pages/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac37f356421df91d4dbafe8604f6e4639cf7a42", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/tinymce.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Products.cshtml"
  
    ViewData["Title"] = "Add Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Navbar -->
<nav aria-label=""Page navigation example"">
    <ul class=""pagination"">
        <!-- Button Back-->
        <li class=""page-item"" style=""padding: 1px;"">
            <a href=""#"" class=""btn btn-secondary btn-icon"" aria-label=""Previous"">
                <i class=""ci-arrow-left""></i>
            </a>
        </li>
        <!-- View Title -->
        <li class=""page-item"">
            <h4 class=""ml-3 mt-2"">");
#nullable restore
#line 18 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Products.cshtml"
                             Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        </li>
    </ul>
</nav>

<!-- Row 8:4 -->
<div class=""row"">
    <!-- Colume 8 -->
    <div class=""col-8"">
        <!-- Card Main -->
        <div class=""card"">
            <div class=""card-body"">
                <!-- Input Title -->
                <div>
                    <label for=""title-input"" class=""form-label"">Title</label>
                    <input class=""form-control"" type=""text"" id=""title-input"" placeholder=""Short sleeve t-shirt"">
                </div>
                <!-- Textarea Description -->
                <div class=""mt-3"">
                    <label for=""description-input"" class=""form-label"">Description</label>
                    <textarea class=""form-control"" type=""text"" id=""description-input""></textarea>
                </div>
            </div>
        </div>
        <!-- Card Media -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Media</h5>
                <!-- Inputfiles Media -->");
            WriteLiteral(@"
                <div class=""file-drop-area"">
                    <div class=""file-drop-icon ci-cloud-upload""></div>
                    <span class=""file-drop-message"">Drag and drop here to upload</span>
                    <input type=""file"" class=""file-drop-input"">
                    <button type=""button"" class=""file-drop-btn btn btn-primary btn-sm"">Or select file</button>
                </div>
            </div>
        </div>
        <!-- Card Pricing -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Pricing</h5>
                <div class=""row"">
                    <!-- Price input -->
                    <div class=""col-6"">
                        <label for=""price-input"" class=""form-label"">Price</label>
                        <div class=""input-group"">
                            <span class=""input-group-text""><i class=""ci-dollar""></i></span>
                            <input class=""form-control"" type=""text"" id=""price-in");
            WriteLiteral(@"put"" placeholder=""0"">
                        </div>
                    </div>
                    <!-- Compare input -->
                    <div class=""col-6"">
                        <label for=""compare-input"" class=""form-label"">Compare at price</label>
                        <div class=""input-group"">
                            <span class=""input-group-text""><i class=""ci-dollar""></i></span>
                            <input class=""form-control"" type=""text"" id=""compare-input"" placeholder=""0"">
                            <!-- Compare tooltips -->
                            <span class=""input-group-text"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom""
                                data-bs-html=""true"" title=""To show reduced price,
move the product's original
price into Compare at price.
Enter a lower value into Price.""><i class=""ci-idea""></i></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-body");
            WriteLiteral(@" border-top"">
                <div class=""row"">
                    <!-- Cost input -->
                    <label for=""cost-input"" class=""form-label"">Cost per item</label>
                    <div class=""col-6"">
                        <div class=""input-group"">
                            <span class=""input-group-text""><i class=""ci-dollar""></i></span>
                            <input class=""form-control"" type=""number"" id=""cost-input"" placeholder=""0"">
                        </div>
                    </div>
                    <!-- Margin span -->
                    <div class=""col-3"">
                        <p class=""text-muted mb-0"">Margin</p>
                        <span>-</span>
                    </div>
                    <!-- Profit span -->
                    <div class=""col-3"">
                        <p class=""text-muted mb-0"">Profit</p>
                        <span>-</span>
                    </div>
                </div>
            </div>
        </div>
        <!");
            WriteLiteral(@"-- Card Inventory -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Inventory</h5>
            </div>
        </div>
        <!-- Card Shipping -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Shipping</h5>
            </div>
        </div>
        <!-- Card Variants -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Variants</h5>
            </div>
        </div>
        <!-- Card Search engine  -->
        <div class=""card mt-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">Search engine listing preview</h5>
            </div>
        </div>
    </div>
    <!-- Colume 4 -->
    <div class=""col-4"">
        <!-- Card Product status -->
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Product status</h5>
            </");
            WriteLiteral("div>\r\n        </div>\r\n        <!-- Card Organization -->\r\n        <div class=\"card mt-3\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">Organization</h5>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c80300763a52626e9a849f57674cf31e2799cb49973", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 150 "D:\Dev\GitHub\E_Commerce\EC.UI\EC.UI\Pages\Products.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    tinymce.init({\r\n        selector: \'textarea\',\r\n        plugins: \'advlist autolink lists link image charmap print preview hr anchor pagebreak\',\r\n        toolbar_mode: \'floating\',\r\n    });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ProductsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ProductsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ProductsModel>)PageContext?.ViewData;
        public MyApp.Namespace.ProductsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
