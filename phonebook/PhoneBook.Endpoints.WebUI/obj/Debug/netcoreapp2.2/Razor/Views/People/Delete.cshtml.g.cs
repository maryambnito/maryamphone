#pragma checksum "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f84774d0ebf4a331150e4ec06271d14e1b2c7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Delete), @"mvc.1.0.view", @"/Views/People/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Delete.cshtml", typeof(AspNetCore.Views_People_Delete))]
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
#line 2 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\_ViewImports.cshtml"
using PhoneBook.Endpoints.WebUI.Models;

#line default
#line hidden
#line 3 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\_ViewImports.cshtml"
using PhoneBook.Endpoints.WebUI.Models.AAA;

#line default
#line hidden
#line 4 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\_ViewImports.cshtml"
using PhoneBook.Domain.Core.Peoples;

#line default
#line hidden
#line 5 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\_ViewImports.cshtml"
using PhoneBook.Endpoints.WebUI.Models.Phones;

#line default
#line hidden
#line 6 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\_ViewImports.cshtml"
using PhoneBook.Endpoints.WebUI.Models.People;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f84774d0ebf4a331150e4ec06271d14e1b2c7c", @"/Views/People/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519f123e3ea1d32d46025addbd4231fca3445cee", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsPersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConfirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "People", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(161, 125, true);
            WriteLiteral("\r\n<h1>Delete member!</h1>\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-5  alert alert-danger\">Are you sure you want to delete ");
            EndContext();
            BeginContext(287, 15, false);
#line 12 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(302, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(304, 14, false);
#line 12 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(318, 67, true);
            WriteLiteral(" </div>\r\n</div>\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-2 \">\r\n");
            EndContext();
#line 17 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
           var imgSrc = String.Format("data:image/gif;base64,{0}", Model.Image); 

#line default
#line hidden
            BeginContext(469, 14, true);
            WriteLiteral("\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 483, "\"", 496, 1);
#line 19 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
WriteAttributeValue("", 489, imgSrc, 489, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 144, true);
            WriteLiteral(" height=\"150\" width=\"150\" class=\"img-thumbnail\" alt=\"Alternate Text\" />\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        <div>\r\n            <b>");
            EndContext();
            BeginContext(641, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c7897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 23 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(676, 6, true);
            WriteLiteral(":</b> ");
            EndContext();
            BeginContext(683, 15, false);
#line 23 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(698, 48, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <b>");
            EndContext();
            BeginContext(746, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c9904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 26 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(780, 7, true);
            WriteLiteral(" :</b> ");
            EndContext();
            BeginContext(788, 14, false);
#line 26 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                   Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(802, 48, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <b>");
            EndContext();
            BeginContext(850, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c11910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(881, 7, true);
            WriteLiteral(" :</b> ");
            EndContext();
            BeginContext(889, 11, false);
#line 29 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(900, 48, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <b>");
            EndContext();
            BeginContext(948, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c13908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 32 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Address);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(981, 7, true);
            WriteLiteral(" :</b> ");
            EndContext();
            BeginContext(989, 13, false);
#line 32 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
                                                  Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 46, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n");
            EndContext();
            BeginContext(1048, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c15917", async() => {
                BeginContext(1133, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1139, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21f84774d0ebf4a331150e4ec06271d14e1b2c7c16305", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 38 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.personId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1181, 70, true);
                WriteLiteral("\r\n    <input type=\"submit\" class=\"btn btn-danger\" value=\"حذف شود\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsPersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
