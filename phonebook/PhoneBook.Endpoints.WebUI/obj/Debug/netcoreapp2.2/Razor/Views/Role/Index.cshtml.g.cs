#pragma checksum "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9baef2107ae2817fd4dfc83ceed2aa2fddfd86df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Index.cshtml", typeof(AspNetCore.Views_Role_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9baef2107ae2817fd4dfc83ceed2aa2fddfd86df", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4678a8d08d1ca1b43a1601b5c65e777078335def", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(187, 82, true);
            WriteLiteral("<table>\r\n    <tr>\r\n        <th>\r\n            Role Name\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 13 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\Role\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(310, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(359, 9, false);
#line 17 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\Role\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(368, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 20 "M:\phonebook\PhoneBook2021\maryamphone\phonebook\PhoneBook.Endpoints.WebUI\Views\Role\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(413, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
