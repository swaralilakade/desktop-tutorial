#pragma checksum "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b25bd90e6e9e88813d483ab551f93e6651e0bd8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
using CRM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25bd90e6e9e88813d483ab551f93e6651e0bd8b", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a98b6fc9fbcaa36df3430de3d3a60654378b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
  
    ViewBag.Title = "Customers Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Customers List</h2>\r\n");
#nullable restore
#line 8 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
  

    Customer theCustomers=ViewData["customer"] as Customer;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table style=\"font-family:Arial\">\r\n    <tr>\r\n        <td><b>Customer :</b></td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Customer Name:</b></td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Contact Number:</b></td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n        <td><b>Email Address:</b></td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td><b>Location :</b></td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td><b>Age :</b></td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(theCustomers.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 42 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(Html.ActionLink("Update", "Update", "Customers", new { id = theCustomers.Id }, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n         <td>\r\n            ");
#nullable restore
#line 45 "C:\Users\Admin\Downloads\code\OnlineShopping (11)\OnlineShopping\TransflowerStoreWeb\Views\Customers\Details.cshtml"
       Write(Html.ActionLink("Delete", "Delete", "Customers", new { id = theCustomers.Id }, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n</table>\r\n\r\n");
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
