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

namespace BetterCms.Module.Pages.Views.Filter
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
    
    #line 1 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Filter/PagesFilterTemplate.cshtml")]
    public partial class PagesFilterTemplate : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Filter.PagesGridViewModel<BetterCms.Module.Pages.ViewModels.SiteSettings.SiteSettingPageViewModel>>
    {
        public PagesFilterTemplate()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


WriteLiteral("\r\n    <div id=\"bcms-filter-template\">\r\n        <div class=\"bcms-grid-filtering\" d" +
"ata-bind=\"css: { \'bcms-active-filter\': isVisible() }\">\r\n            <div class=\"" +
"bcms-filterbox\" data-bind=\"click: toggleFilter\">\r\n                ");


            
            #line 9 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
           Write(PagesGlobalization.SiteSettings_Pages_Filter);

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div class=\"bcms-filter-modified\" data-bind=\"style: { display: " +
"isEdited() ? \'inline-block\' : \'none\' }\">");


            
            #line 10 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                                                  Write(PagesGlobalization.SiteSettings_Pages_FilterIsModified);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""bcms-tags-block"" style=""display: none;"" data-bind=""visible: isVisible(), enterPress: searchWithFilter"">
            <div class=""bcms-featured-tags"">
                <div class=""bcms-clearfix"">

                    <div class=""bcms-filter-options"" data-bind=""with: tags"">
                        <div class=""bcms-filter-text"">");


            
            #line 18 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByTags);

            
            #line default
            #line hidden
WriteLiteral(@"</div>
                        <div class=""bcms-filter-field-holder"">
                            <input type=""text"" class=""bcms-add-tags-field"" data-bind=""
                            css: { 'bcms-tag-validation-error': newItem.hasError() },
                            value: newItem,
                            valueUpdate: 'afterkeydown',
                            escPress: clearItem,
                            autocompleteList: 'onlyExisting'"" />
                            <!-- ko if: newItem.hasError()  -->
                            <span class=""bcms-tag-field-validation-error"">
                                <span data-bind=""text: newItem.validationMessage()""></span>
                            </span>
                            <!-- /ko -->
                        </div>
                    </div>

                    <div class=""bcms-filter-options"">
                        <div class=""bcms-filter-text"">");


            
            #line 35 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByCategory);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <select class=\"bcms-global-select\" name=\"Category" +
"Id\" data-bind=\"options: categories, value: categoryId, optionsText: \'Value\', opt" +
"ionsValue: \'Key\'\" />\r\n                    </div>\r\n\r\n");


            
            #line 39 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                     if (Model.Languages != null && Model.Languages.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div class=\"bcms-filter-options\">\r\n                      " +
"      <div class=\"bcms-filter-text\">");


            
            #line 42 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                     Write(PagesGlobalization.SiteSettings_Pages_FilterByLanguage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            <select class=\"bcms-global-select\" name=\"Lang" +
"uageId\" data-bind=\"options: languages, value: languageId, optionsText: \'Value\', " +
"optionsValue: \'Key\'\" />\r\n                        </div>\r\n");


            
            #line 45 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"bcms-filter-options\">\r\n                        " +
"<div class=\"bcms-filter-text\">");


            
            #line 48 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByStatus);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        ");


            
            #line 49 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.Status, new List<SelectListItem>(), new
                                                                      {
                                                                          data_bind = "options: statuses, value: status, optionsText: 'Value', optionsValue: 'Key'",
                                                                          @class = "bcms-global-select"
                                                                      }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"bcms-filter-optio" +
"ns\">\r\n                        <div class=\"bcms-filter-text\">");


            
            #line 57 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterBySEO);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        ");


            
            #line 58 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.SeoStatus, new List<SelectListItem>(), new
                                                                                            {
                                                                                                data_bind = "options: seoStatuses, value: seoStatus, optionsText: 'Value', optionsValue: 'Key'",
                                                                                                @class = "bcms-global-select"
                                                                                            }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    \r\n                    <div clas" +
"s=\"bcms-filter-options\">\r\n                        <div class=\"bcms-filter-text\">" +
"");


            
            #line 66 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                 Write(PagesGlobalization.SiteSettings_Pages_FilterByLayout);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        ");


            
            #line 67 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.DropDownListFor(m => m.Layout, new List<SelectListItem>(), new
                                                                      {
                                                                          data_bind = "options: layouts, value: layout, optionsText: 'Value', optionsValue: 'Key'",
                                                                          @class = "bcms-global-select"
                                                                      }));

            
            #line default
            #line hidden
WriteLiteral(@"
                    </div>

                </div>

                <div class=""bcms-single-tag-holder"" data-bind=""foreach: tags.items()"">
                    <div class=""bcms-single-tag"" data-bind=""css: { 'bcms-single-tag-active': isActive() }"">
                        <span data-bind=""text: name()""></span><a data-bind=""    click: remove"">");


            
            #line 78 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                          Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral(@"</a>
                    </div>
                    <input type=""hidden"" data-bind=""attr: { name: getItemInputName($index()) + '.Key', value: id() }"" />
                    <input type=""hidden"" data-bind=""attr: { name: getItemInputName($index()) + '.Value', value: name() }"" />
                </div>

            </div>

            <div class=""bcms-clearfix"">
                <div class=""bcms-check-field-holder"" style=""float: none;"">
                    ");


            
            #line 88 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
               Write(Html.CheckBoxFor(model => model.IncludeArchived, new { data_bind = "checked: includeArchived" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span class=\"bcms-pointer\" data-bind=\"click: changeIncludeA" +
"rchived\">");


            
            #line 89 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                   Write(PagesGlobalization.SiteSettings_Pages_FilterIncludeArchived);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n");


            
            #line 91 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                 if (!Model.HideMasterPagesFiltering)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"bcms-check-field-holder\">\r\n                      " +
"  ");


            
            #line 94 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                   Write(Html.CheckBoxFor(model => model.IncludeMasterPages, new { data_bind = "checked: includeMasterPages" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <span class=\"bcms-pointer\" data-bind=\"click: changeIncl" +
"udeMasterPages\">");


            
            #line 95 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                          Write(PagesGlobalization.SiteSettings_Pages_FilterIncludeMasterPages);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n");


            
            #line 97 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div class=\"bcms-btn-field-holder\">\r\n                    <div c" +
"lass=\"bcms-btn-links-small\" data-bind=\"click: clearFilter\">");


            
            #line 100 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                                Write(PagesGlobalization.SiteSettings_Pages_FilterClear);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div class=\"bcms-btn-small\" data-bind=\"click: searchW" +
"ithFilter\">");


            
            #line 101 "..\..\Views\Filter\PagesFilterTemplate.cshtml"
                                                                               Write(PagesGlobalization.SiteSettings_Pages_FilterSearch);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");


        }
    }
}
#pragma warning restore 1591