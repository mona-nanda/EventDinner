#pragma checksum "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc000b1c20148121e7a5ace92f363ff67ecec12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dinner_Logged), @"mvc.1.0.view", @"/Views/Dinner/Logged.cshtml")]
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
#line 1 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/_ViewImports.cshtml"
using NerdDinnerBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/_ViewImports.cshtml"
using NerdDinnerBooking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc000b1c20148121e7a5ace92f363ff67ecec12", @"/Views/Dinner/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c81713bdcd86c6e409e3834560a610ecb6932d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dinner_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdDinner.Models.BookDinner>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
  
    ViewData["Title"] = "NerdDinner";
    var rsvps = (Dictionary<int, int>)ViewData["rsvp"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""form-group"" id=""addressmain1"" style=""width:200px;margin-top:5%"">
    <input id=""address1"" class=""form-control"" />
</div>
<div id=""myMap"" style=""position:relative;width:900px;height:400px; margin-top:5%;margin-left:5%""></div>

<table class=""table"" style=""margin-top: 5%;"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 18 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc000b1c20148121e7a5ace92f363ff67ecec124989", async() => {
                WriteLiteral(" ");
#nullable restore
#line 28 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    RSVP(");
#nullable restore
#line 29 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                          if (@rsvps.ContainsKey(@item.DinnerId)){

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                                                             Write(rsvps[@item.DinnerId]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                                                                                        }else {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h6>0</h6>");
#nullable restore
#line 29 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                                                                                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(")\r\n                    ");
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
#nullable restore
#line 28 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
                                              WriteLiteral(item.DinnerId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "/Users/mona.nandwani/Documents/NerdDinnerBooking/NerdDinnerBooking/Views/Dinner/Logged.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc000b1c20148121e7a5ace92f363ff67ecec128917", async() => {
                WriteLiteral("Register New Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdDinner.Models.BookDinner>> Html { get; private set; }
    }
}
#pragma warning restore 1591