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
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Category\CategoriesTemplate.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Category\CategoriesTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Category\CategoriesTemplate.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Category\CategoriesTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/CategoriesTemplate.cshtml")]
    public partial class _Views_Category_CategoriesTemplate_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Category.CategoryTemplateViewModel>
    {
        public _Views_Category_CategoriesTemplate_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Views\Category\CategoriesTemplate.cshtml"
   var canEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent); 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Category\CategoriesTemplate.cshtml"
Write(Html.Tooltip(Model.TooltipDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Views\Category\CategoriesTemplate.cshtml"
Write(RootGlobalization.CategoriesTemplate_AddCategories_Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-field-wapper\"");

WriteLiteral(" data-bind=\"visible: isExpanded()\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(@" data-bind=""
                    css: { 'bcms-tag-validation-error': newItem.hasError() },
                    value: newItem,
                    valueUpdate: 'afterkeydown',
                    hasfocus: hasfocus,
                    autocompleteList: 'onlyExisting',
                    enterPress: function(){},
                    escPress: clearItem""");

WriteLiteral(" />\r\n    <!-- ko if: newItem.hasError()  -->\r\n    <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n    </span>\r\n    <!-- /ko -->\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: items()\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral("><span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"");

            
            #line 31 "..\..\Views\Category\CategoriesTemplate.cshtml"
                                                                                                                                           Write(canEdit ? "click: remove" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Category\CategoriesTemplate.cshtml"
                                                                                                                                                                                       Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a></div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()), value: id() }\"");

WriteLiteral(" />\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591