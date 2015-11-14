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
    
    #line 1 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.ViewModels.Blog;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Blog.ViewModels.Filter;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Partial/BlogsFilterTemplate.cshtml")]
    public partial class _Views_Blog_Partial_BlogsFilterTemplate_cshtml : System.Web.Mvc.WebViewPage<BlogsGridViewModel<SiteSettingBlogPostViewModel>>
    {
        public _Views_Blog_Partial_BlogsFilterTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-filter-holder\"");

WriteLiteral(" id=\"bcms-filter-template\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-grid-filtering\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-filter\': isVisible() }\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filterbox\"");

WriteLiteral(" data-bind=\"click: toggleFilter\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 11 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
       Write(BlogGlobalization.SiteSettings_Blogs_Filter);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-filter-modified\"");

WriteLiteral(" data-bind=\"style: { display: isEdited() ? \'inline-block\' : \'none\' }\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                                              Write(BlogGlobalization.SiteSettings_Blogs_FilterIsModified);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-filter-selection-block\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: isVisible()\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-filter-controls\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByTags);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-field-holder\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(" data-bind=\"\r\n    css: { \'bcms-tag-validation-error\': newItem.hasError() },\r\n    " +
"value: newItem,\r\n    valueUpdate: \'afterkeydown\',\r\n    escPress: clearItem,\r\n   " +
" autocompleteList: \'onlyExisting\'\"");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError()  -->\r\n               " +
"         <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByCategory);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-field-holder\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(@" data-bind=""
                            css: { 'bcms-tag-validation-error': newItem.hasError() },
                            value: newItem,
                            valueUpdate: 'afterkeydown',
                            escPress: clearItem,
                            autocompleteList: 'onlyExisting'""");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError()  -->\r\n               " +
"         <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 54 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterByStatus);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
               Write(Html.DropDownListFor(m => m.Status, new List<SelectListItem>(), new
                                                                      {
                                                                          data_bind = "options: statuses, value: status, optionsText: 'Value', optionsValue: 'Key'",
                                                                          @class = "bcms-global-select"
                                                                      }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 62 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterBySEO);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 63 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
               Write(Html.DropDownListFor(m => m.SeoStatus, new List<SelectListItem>(), new
                                                                                            {
                                                                                                data_bind = "options: seoStatuses, value: seoStatus, optionsText: 'Value', optionsValue: 'Key'",
                                                                                                @class = "bcms-global-select"
                                                                                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 69 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                 if (Model.Languages != null && Model.Languages.Any())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-filter-options\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-filter-text\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                 Write(BlogGlobalization.SiteSettings_Blogs_FilterByLanguage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" name=\"LanguageId\"");

WriteLiteral(" data-bind=\"options: languages, value: languageId, optionsText: \'Value\', optionsV" +
"alue: \'Key\'\"");

WriteLiteral(" />\r\n                    </div>\r\n");

            
            #line 75 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: tags.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                      Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Key\', value: id() }\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()) + \'.Value\', value: name() }\"" +
"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: categories.items()\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></span><a");

WriteLiteral(" data-bind=\"    click: remove\"");

WriteLiteral(">");

            
            #line 87 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                                      Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Key\', value: id() }\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: \'Categories[\' + $index() + \'].Value\', value: name() }\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-clearfix\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-check-field-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 95 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
           Write(Html.CheckBoxFor(model => model.IncludeArchived, new { data_bind = "checked: includeArchived" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" class=\"bcms-pointer\"");

WriteLiteral(" data-bind=\"click: changeIncludeArchived\"");

WriteLiteral(">");

            
            #line 96 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                               Write(BlogGlobalization.SiteSettings_Blogs_FilterIncludeArchived);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"bcms-btn-field-holder\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: clearFilter\"");

WriteLiteral(">");

            
            #line 99 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                       Write(BlogGlobalization.SiteSettings_Blogs_FilterClear);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: searchWithFilter\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Blog\Partial\BlogsFilterTemplate.cshtml"
                                                                             Write(BlogGlobalization.SiteSettings_Blogs_FilterSearch);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
