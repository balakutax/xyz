﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using RJ.Tokoku;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProductGroup/Details.cshtml")]
    public partial class _Views_ProductGroup_Details_cshtml : System.Web.Mvc.WebViewPage<RJ.Tokoku.DataLayer.Products.ProductGroup>
    {
        public _Views_ProductGroup_Details_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\ProductGroup\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Details</h2>\r\n");

            
            #line 9 "..\..\Views\ProductGroup\Details.cshtml"
 if (ViewBag.IsDelete == true)
{

            
            #line default
            #line hidden
WriteLiteral("    <div>Are you sure want to delete this data?</div>\r\n");

            
            #line 12 "..\..\Views\ProductGroup\Details.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <h4>ProductGroup</h4>\r\n        <hr />\r\n        <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductGroupCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductGroupCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n\r\n            <dt>\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dt>\r\n\r\n            <dd>\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n");

            
            #line 34 "..\..\Views\ProductGroup\Details.cshtml"
    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\ProductGroup\Details.cshtml"
     if (ViewBag.IsDelete == true)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n\r\n");

            
            #line 38 "..\..\Views\ProductGroup\Details.cshtml"
            
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\ProductGroup\Details.cshtml"
             using (Html.BeginForm("Delete", "ProductGroup"))
            {
                
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\ProductGroup\Details.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\ProductGroup\Details.cshtml"
           Write(Html.HiddenFor(x => x.ProductGroupCode));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\ProductGroup\Details.cshtml"
                                                        

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Delete\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n");

            
            #line 43 "..\..\Views\ProductGroup\Details.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 45 "..\..\Views\ProductGroup\Details.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n");

WriteLiteral("        ");

            
            #line 47 "..\..\Views\ProductGroup\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { productGroupCode = Model.ProductGroupCode }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n");

WriteLiteral("        ");

            
            #line 48 "..\..\Views\ProductGroup\Details.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");

        }
    }
}
#pragma warning restore 1591