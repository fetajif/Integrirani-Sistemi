#pragma checksum "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6e2c04af1a47de3ed0602e8ffc86d692c880de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
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
#line 1 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\_ViewImports.cshtml"
using DomasnaIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\_ViewImports.cshtml"
using DomasnaIS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6e2c04af1a47de3ed0602e8ffc86d692c880de", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295585ec142248dc689066ca476ae2757b33bcbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DomasnaIS.Domain.DTO.TicketsFilteredByDateDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTicketToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Available Tickets</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6e2c04af1a47de3ed0602e8ffc86d692c880de6447", async() => {
                WriteLiteral("Add New Ticket");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h3>Filter Tickets by date:</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6e2c04af1a47de3ed0602e8ffc86d692c880de7807", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
       Write(Html.HiddenFor(model => model.AllTickets));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d6e2c04af1a47de3ed0602e8ffc86d692c880de8381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 18 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CurrentDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Filter by Date\" class=\"btn btn-primary\"/>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 25 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
     for (int i = 0; i < Model.AllTickets.Count; i++)
     {
        var item = Model.AllTickets[i];

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 32 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
        }



#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 35rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 955, "\"", 981, 1);
#nullable restore
#line 37 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
WriteAttributeValue("", 961, item.MoviePosterURL, 961, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 40%\"");
            BeginWriteAttribute("alt", " alt=\"", 1002, "\"", 1056, 8);
            WriteAttributeValue("", 1008, "Image", 1008, 5, true);
            WriteAttributeValue(" ", 1013, "for", 1014, 4, true);
            WriteAttributeValue(" ", 1017, "ticket", 1018, 7, true);
            WriteAttributeValue(" ", 1024, "for", 1025, 4, true);
            WriteAttributeValue(" ", 1028, "the", 1029, 4, true);
            WriteAttributeValue(" ", 1032, "movie", 1033, 6, true);
#nullable restore
#line 37 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
WriteAttributeValue(" ", 1038, item.MovieTitle, 1039, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1055, "!", 1055, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                    <div class=\"card-body\">\r\n                        <h3 class=\"card-title\">");
#nullable restore
#line 40 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                          Write(item.MovieTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\">\r\n                            Genre: ");
#nullable restore
#line 42 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                              Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Imdb Movie Rating: ");
#nullable restore
#line 42 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                                              Write(item.MovieRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            Available from: ");
#nullable restore
#line 43 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                       Write(item.DateAvailableFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            Available to: ");
#nullable restore
#line 44 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                     Write(item.DateAvailableTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n                        </p>\r\n\r\n                        <h6>Price: ");
#nullable restore
#line 48 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                              Write(item.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n\r\n                    <div class=\"card-footer\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6e2c04af1a47de3ed0602e8ffc86d692c880de16079", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6e2c04af1a47de3ed0602e8ffc86d692c880de18376", async() => {
                WriteLiteral("Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 59 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"



            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 65 "C:\Users\User5531\Desktop\6th semester\Integrirani Sistemi\Domasna\DomasnaIS\DomasnaIS\Views\Tickets\Index.cshtml"
            }
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DomasnaIS.Domain.DTO.TicketsFilteredByDateDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
