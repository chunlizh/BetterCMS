﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Content
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
    
    #line 1 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Content\AddPageHtmlContent.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/AddPageHtmlContent.cshtml")]
    public partial class AddPageHtmlContent : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public AddPageHtmlContent()
        {
        }
        public override void Execute()
        {







WriteLiteral("\r\n");


WriteLiteral("\r\n<div class=\"bcms-tab-header\">\r\n    <a class=\"bcms-tab bcms-tab-active\" data-nam" +
"e=\"#bcms-tab-1\">");


            
            #line 12 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                           Write(PagesGlobalization.AddPageContent_RegularContentTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <a class=\"bcms-tab\" data-name=\"#bcms-tab-2\">");


            
            #line 13 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                           Write(PagesGlobalization.AddPageContent_WidgetTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n</div>\r\n");


            
            #line 15 "..\..\Views\Content\AddPageHtmlContent.cshtml"
   ViewBag.CanEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent); 

            
            #line default
            #line hidden
WriteLiteral("<div class=\"bcms-scroll-window\">\r\n    ");


            
            #line 17 "..\..\Views\Content\AddPageHtmlContent.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div class=\"bcms-padded-content\">\r\n            \r\n        <div id=\"bcms-tab-" +
"1\" class=\"bcms-tab-single\">\r\n");


            
            #line 21 "..\..\Views\Content\AddPageHtmlContent.cshtml"
             using (Html.BeginForm<ContentController>(c => c.SavePageHtmlContent(null), FormMethod.Post, new { @id = "bcms-content-form", @class = "bcms-ajax-form" }))
            {              
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/EditHtmlContent", Model));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                 
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsPageContentId"}));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                    
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.ContentId, new { @id = "bcmsContentId"}));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                       
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.PageId));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                      
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(model => model.RegionId, new { @id = "bcmsContentToRegionId" }));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                               
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status"}));

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                                                
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n        <div id=\"bcms-tab-2\" class=\"bcms-tab-single\">\r\n        " +
"    <div class=\"bcms-top-block-holder\">\r\n");


            
            #line 34 "..\..\Views\Content\AddPageHtmlContent.cshtml"
             if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.Administration))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"bcms-btn-links-main\" id=\"bcms-create-advanced-content" +
"-button\">");


            
            #line 36 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                     Write(PagesGlobalization.AddPageContent_WidgetTab_AddNewButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");



WriteLiteral("                <div class=\"bcms-btn-links-main\" id=\"bcms-registeradvanced-conten" +
"t-button\">");


            
            #line 37 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                      Write(PagesGlobalization.AddPageContent_WidgetTab_RegisterButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");


            
            #line 38 "..\..\Views\Content\AddPageHtmlContent.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"bcms-search-block\">\r\n                    <input type=" +
"\"text\" id=\"bcms-advanced-content-search\" class=\"bcms-editor-field-box\" placehold" +
"er=\"");


            
            #line 40 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                                               Write(RootGlobalization.WaterMark_Search);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                    <div class=\"bcms-btn-search\" id=\"bcms-advanced-content-" +
"search-btn\">");


            
            #line 41 "..\..\Views\Content\AddPageHtmlContent.cshtml"
                                                                                  Write(PagesGlobalization.AddPageContent_WidgetTab_SearchButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            <div class=\"bcms-" +
"content-sliders\" id=\"bcms-advanced-contents-container\">\r\n                ");


            
            #line 45 "..\..\Views\Content\AddPageHtmlContent.cshtml"
           Write(Html.Partial("Partial/WidgetCategories", Model.WidgetCategories));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n                \r\n    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591