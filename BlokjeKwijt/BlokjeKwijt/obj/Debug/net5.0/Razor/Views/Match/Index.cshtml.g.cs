#pragma checksum "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb6544facae237dc7ceb41ce7099546b2adc2d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Match_Index), @"mvc.1.0.view", @"/Views/Match/Index.cshtml")]
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
#line 1 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\_ViewImports.cshtml"
using BlokjeKwijt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\_ViewImports.cshtml"
using BlokjeKwijt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
using BlokjeKwijt.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb6544facae237dc7ceb41ce7099546b2adc2d4", @"/Views/Match/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d51c3aa2a2e531339b426d62bfd93317c63498e", @"/Views/_ViewImports.cshtml")]
    public class Views_Match_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb6544facae237dc7ceb41ce7099546b2adc2d43480", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 6 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
           Html.BeginForm();

#line default
#line hidden
#nullable disable
                WriteLiteral("        <select>\r\n");
#nullable restore
#line 8 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
             foreach (var over in Model.UserHasExtraBricks)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb6544facae237dc7ceb41ce7099546b2adc2d44321", async() => {
#nullable restore
#line 10 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
                               Write(over.User.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
                  WriteLiteral(over);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n");
#nullable restore
#line 13 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
           Html.EndForm();

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 16 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
           Html.BeginForm();

#line default
#line hidden
#nullable disable
                WriteLiteral("        <select>\r\n");
#nullable restore
#line 18 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
             foreach (var kwijt in Model.UserHasMissingBricks)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb6544facae237dc7ceb41ce7099546b2adc2d47298", async() => {
#nullable restore
#line 20 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
                                Write(kwijt.User.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
                  WriteLiteral(kwijt);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n");
#nullable restore
#line 23 "C:\Users\David Kamp\Documents\GitHub\BlokjeKwijtX\BlokjeKwijt\BlokjeKwijt\Views\Match\Index.cshtml"
           Html.EndForm();

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
