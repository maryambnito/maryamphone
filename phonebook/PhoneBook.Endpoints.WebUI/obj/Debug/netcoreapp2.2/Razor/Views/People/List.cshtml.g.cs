#pragma checksum "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1062a156459fa690d0d8f0c682542bfd5973d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_List), @"mvc.1.0.view", @"/Views/People/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/List.cshtml", typeof(AspNetCore.Views_People_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1062a156459fa690d0d8f0c682542bfd5973d42", @"/Views/People/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4678a8d08d1ca1b43a1601b5c65e777078335def", @"/Views/_ViewImports.cshtml")]
    public class Views_People_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhoneBook.Domain.Core.Peoples.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "People", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
            BeginContext(98, 172, true);
            WriteLiteral("<table class=\"table table-bordered table-striped\">\n    <tr>\n        <th>First Name</th>\n        <th>Last Name</th>\n        <th>Email</th>\n        <td>Detail</td>\n    </tr>\n");
            EndContext();
#line 14 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(309, 13, true);
            WriteLiteral("<tr>\n    <td>");
            EndContext();
            BeginContext(323, 14, false);
#line 17 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
   Write(item.FristName);

#line default
#line hidden
            EndContext();
            BeginContext(337, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(352, 13, false);
#line 18 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
   Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(365, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(380, 10, false);
#line 19 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(390, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(404, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1062a156459fa690d0d8f0c682542bfd5973d425637", async() => {
                BeginContext(475, 6, true);
                WriteLiteral("Detail");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
                                                         WriteLiteral(item.Id);

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
            BeginContext(485, 12, true);
            WriteLiteral("</td>\n</tr>\n");
            EndContext();
#line 22 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
}

#line default
#line hidden
            BeginContext(499, 8, true);
            WriteLiteral("</table>");
            EndContext();
#line 23 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\People\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhoneBook.Domain.Core.Peoples.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
