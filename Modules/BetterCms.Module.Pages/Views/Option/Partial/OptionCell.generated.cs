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

namespace BetterCms.Module.Pages.Views.Option.Partial
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
    
    #line 1 "..\..\Views\Option\Partial\OptionCell.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Option\Partial\OptionCell.cshtml"
    using BetterCms.Module.Root.Mvc.Grids;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Option/Partial/OptionCell.cshtml")]
    public partial class OptionCell : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.Mvc.EditableGrid.OptionValueEditableGridColumn>
    {
        public OptionCell()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


WriteLiteral("\r\n");



WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() != 5 && type() != 4 && type() != 99 --" +
">\r\n    ");


            
            #line 8 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridCellTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n");



WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 5  -->\r\n    ");


            
            #line 13 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridBooleanCellTemplate, new EditableGridBooleanColumn(Model.HeaderTitle, Model.SortColumn, Model.ValueBind)
                                                                           {
                                                                               HiddenFieldName = Model.HiddenFieldName,
                                                                               HeaderAttributes = Model.HeaderAttributes,
                                                                               AutoFocus = Model.AutoFocus,
                                                                               CanBeEdited = Model.CanBeEdited,
                                                                               ShowValueAsText = true
                                                                           }));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n");



WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 4  -->\r\n<td ");


            
            #line 25 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");


            
            #line 26 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko if: isActive() -->\r\n");



WriteLiteral(@"        <div class=""bcms-input-field-holder"">
            <div class=""bcms-date-input-box bcms-options-date"">
                <input class=""bcms-editor-field-box bcms-datepicker"" data-bind=""
                    css: { 'bcms-input-validation-error': !isNew() && ");


            
            #line 32 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                  Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");


            
            #line 32 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                 Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() },\r\n                    value: ");


            
            #line 33 "..\..\Views\Option\Partial\OptionCell.cshtml"
                       Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(@",
                    valueUpdate: 'afterkeydown', 
                    click: onItemSelect,
                    event: {blur: onBlurField, focus: onItemSelect},
                    enterPress: onSave, 
                    escPress: onCancelEdit,
                    afterRender: initDatePickers()
                    ");


            
            #line 40 "..\..\Views\Option\Partial\OptionCell.cshtml"
                Write(Model.AutoFocus ? ", hasfocus: isActive() && hasFocus" : "");

            
            #line default
            #line hidden
WriteLiteral(" \" />\r\n            \r\n                <!-- ko if: !isNew() &&  ");


            
            #line 42 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                     Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError && ");


            
            #line 42 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                    Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".hasError() -->\r\n                <span class=\"bcms-field-validation-error\">\r\n    " +
"                <span data-bind=\"html: ");


            
            #line 44 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                       Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral(".validationMessage()\"></span>\r\n                </span>\r\n                <!-- /ko " +
"-->\r\n            </div>\r\n        </div>\r\n");



WriteLiteral("        <!-- /ko -->\r\n");



WriteLiteral("        <!-- ko ifnot: isActive() -->\r\n");


            
            #line 51 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <a class=\"bcms-tables-link\" data-bind=\"text: ");


            
            #line 52 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"></a>    \r\n");


            
            #line 53 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");


            
            #line 56 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n<!-- /ko -->\r\n\r\n");



WriteLiteral("\r\n<!-- ko if: !useDefaultValue() && type() == 99  -->\r\n<td ");


            
            #line 62 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");


            
            #line 63 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- ko if: isActive() -->\r\n");



WriteLiteral("        <input style=\"width: 70%\" class=\"bcms-editor-field-box\" type=\"text\" reado" +
"nly=\"readonly\" data-bind=\"value: ");


            
            #line 66 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                              Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");


            
            #line 66 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                                                                            Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("(), \r\n            click: onItemSelect,\r\n            event: {blur: onBlurField, fo" +
"cus: onItemSelect},\r\n            enterPress: onSave, \r\n            escPress: onC" +
"ancelEdit\r\n            ");


            
            #line 71 "..\..\Views\Option\Partial\OptionCell.cshtml"
        Write(Model.AutoFocus ? ", hasfocus: isActive() && hasFocus" : "");

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");



WriteLiteral("        <div class=\"bcms-btn-small\" data-bind=\"\r\n                    click: onCus" +
"tomOptionExecute.bind($data, $data, ");


            
            #line 73 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral(", ");


            
            #line 73 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                                          Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("),\r\n                    event: {blur: onBlurField, focus: onItemSelect},\r\n       " +
"             enterPress: onSave, \r\n                    escPress: onCancelEdit\">." +
"..</div>\r\n");



WriteLiteral("        <!-- /ko -->\r\n");



WriteLiteral("        <!-- ko ifnot: isActive() -->\r\n");


            
            #line 79 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <a class=\"bcms-tables-link\" data-bind=\"text: ");


            
            #line 80 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");


            
            #line 80 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                           Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"></a>    \r\n");


            
            #line 81 "..\..\Views\Option\Partial\OptionCell.cshtml"
     if (Model.CanBeEdited)
    {

            
            #line default
            #line hidden
WriteLiteral("        <!-- /ko -->\r\n");


            
            #line 84 "..\..\Views\Option\Partial\OptionCell.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n<!-- /ko -->\r\n\r\n");



WriteLiteral("\r\n<!-- ko if: useDefaultValue() && type() == 5  -->\r\n    ");


            
            #line 90 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Partial(RootModuleConstants.EditableGridBooleanCellTemplate, new EditableGridBooleanColumn(null, null, Model.ValueBind)
                                                                           {
                                                                               CanBeEdited = false,
                                                                               ShowValueAsText = true
                                                                           }));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- /ko -->\r\n\r\n<!-- ko if: useDefaultValue() && type() != 5  -->\r\n<td ");


            
            #line 98 "..\..\Views\Option\Partial\OptionCell.cshtml"
Write(Html.Raw(Model.Attributes));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <a class=\"bcms-tables-link\" data-bind=\"text: ");


            
            #line 99 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                             Write(Model.CustomValueBind);

            
            #line default
            #line hidden
WriteLiteral("() || ");


            
            #line 99 "..\..\Views\Option\Partial\OptionCell.cshtml"
                                                                           Write(Model.ValueBind);

            
            #line default
            #line hidden
WriteLiteral("()\"></a>\r\n</td>\r\n<!-- /ko -->\r\n");


        }
    }
}
#pragma warning restore 1591