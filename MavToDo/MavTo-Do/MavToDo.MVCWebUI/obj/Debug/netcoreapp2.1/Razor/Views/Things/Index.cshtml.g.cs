#pragma checksum "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063fc2f060d7dfdd9a72e9ac9cd82ff9906d2830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Things_Index), @"mvc.1.0.view", @"/Views/Things/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Things/Index.cshtml", typeof(AspNetCore.Views_Things_Index))]
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
#line 1 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\_ViewImports.cshtml"
using MavToDo.MVCWebUI;

#line default
#line hidden
#line 2 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\_ViewImports.cshtml"
using MavToDo.MVCWebUI.Models;

#line default
#line hidden
#line 1 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
using MavToDo.Business.Abstract;

#line default
#line hidden
#line 2 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063fc2f060d7dfdd9a72e9ac9cd82ff9906d2830", @"/Views/Things/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0969fe0a927f49aafd65f1203444899c272c9f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Things_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThingsToDoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Things", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddThings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pagination"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::MavToDo.MVCWebUI.TagHelpers.PagingTagHelper __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/code/_OperationLayout.cshtml";

#line default
#line hidden
            BeginContext(202, 61, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-8\">\r\n        <h6>");
            EndContext();
            BeginContext(264, 17, false);
#line 11 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
       Write(Model.CurrentName);

#line default
#line hidden
            EndContext();
            BeginContext(281, 55, true);
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
            EndContext();
            BeginContext(336, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81b1622bdf0e4d9aa59d36a8597d2d5d", async() => {
                BeginContext(468, 48, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> Add somethings to do");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
                                                                    WriteLiteral(Model.CurrentCategory);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(520, 214, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>To-Do Name</th>\r\n        <th>Start Date</th>\r\n        <th>End Date</th>\r\n        <th>Color</th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 26 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
     foreach (var things in Model.ThingsToDos)
    {

#line default
#line hidden
            BeginContext(789, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 800, "\"", 843, 2);
            WriteAttributeValue("", 808, "background:", 808, 11, true);
#line 28 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
WriteAttributeValue(" ", 819, things.ThingsToDoColor, 820, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 19, true);
            WriteLiteral(">\r\n            <td>");
            EndContext();
            BeginContext(864, 21, false);
#line 29 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
           Write(things.ThingsToDoName);

#line default
#line hidden
            EndContext();
            BeginContext(885, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(909, 22, false);
#line 30 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
           Write(things.ThingsToDoStart);

#line default
#line hidden
            EndContext();
            BeginContext(931, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(955, 20, false);
#line 31 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
           Write(things.ThingsToDoEnd);

#line default
#line hidden
            EndContext();
            BeginContext(975, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(999, 22, false);
#line 32 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
           Write(things.ThingsToDoColor);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1044, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10c78ddd7f524c0490cb4f4adde2ebc3", async() => {
                BeginContext(1156, 35, true);
                WriteLiteral("<i class=\"fas fa-times\"></i> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-thingsId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
                                                                                              WriteLiteral(things.ThingsToDoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["thingsId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-thingsId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["thingsId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1195, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1224, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
            BeginContext(1236, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("things-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eeade4f3721423ca724deb0833348ab", async() => {
            }
            );
            __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper = CreateTagHelper<global::MavToDo.MVCWebUI.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__MavToDo_MVCWebUI_TagHelpers_PagingTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 39 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
__MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.CurrentCategory = Model.CurrentCategory;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
__MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 41 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
__MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "Q:\source\repos\MavTo-Do\MavToDo.MVCWebUI\Views\Things\Index.cshtml"
__MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MavToDo_MVCWebUI_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1508, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThingsToDoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
