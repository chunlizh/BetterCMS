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
    
    #line 7 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Controllers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Models;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.Images;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Images\ImageEditor.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Images/ImageEditor.cshtml")]
    public partial class _Views_Images_ImageEditor_cshtml : System.Web.Mvc.WebViewPage<ImageViewModel>
    {
        public _Views_Images_ImageEditor_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 12 "..\..\Views\Images\ImageEditor.cshtml"
  
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = MediaGlobalization.FileEditor_Dialog_AddTags_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 18 "..\..\Views\Images\ImageEditor.cshtml"
  
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = MediaGlobalization.FileEditor_Dialog_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Views\Images\ImageEditor.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\n\n    <div");

WriteLiteral(" class=\"bcms-window-options\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"bcms-file-manager-inner bcms-clearfix\"");

WriteLiteral(">\n");

            
            #line 30 "..\..\Views\Images\ImageEditor.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\Images\ImageEditor.cshtml"
             using (Html.BeginForm<ImagesController>(f => f.ImageEditor((ImageViewModel)null), FormMethod.Post, new { @class = "bcms-ajax-form", @enctype = "multipart/form-data" }))
            {
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Images\ImageEditor.cshtml"
                                                  
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.Version, new { @id = "image-version-field" }));

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                            
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordX1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX1())" }));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordX2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX2())" }));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordY1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY1())" }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.CropCoordY2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY2())" }));

            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                         
                
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenFor(model => model.ShouldOverride, new { @id = "image-override-field" }));

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                    
            
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.ImageType, new { @data_bind = "value: imageEditorViewModel.imageType()" }));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                     


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n                <div");

WriteLiteral(" data-bind=\"visible: imageEditorViewModel.imageType() == 1\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(MediaGlobalization.ImageEditor_Dialog_CropImage_Title);

            
            #line default
            #line hidden
WriteLiteral("\n\n                        <a");

WriteLiteral(" class=\"bcms-icn-delete-link\"");

WriteLiteral(" data-bind=\"visible: imageEditorViewModel.hasCrop(), click: imageEditorViewModel." +
"removeCrop\"");

WriteLiteral(">Remove crop</a>\n                        <div");

WriteLiteral(" class=\"bcms-crop-checkbox\"");

WriteLiteral(">\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-bind=\"checked: imageEditorViewModel.fit\"");

WriteLiteral(" />\n                            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(" data-bind=\"click: imageEditorViewModel.changeFit\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                      Write(MediaGlobalization.ImageEditor_Dialog_FitImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                        </div>\n                    </div>\n");

WriteLiteral("                    ");

            
            #line 52 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_CropImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n            </div>\n");

            
            #line 55 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-croped-block\"");

WriteLiteral(">\n                    <img");

WriteLiteral(" src=\"\"");

WriteLiteral(" data-bind=\"style: { width: imageEditorViewModel.calculatedWidth() + \'px\', height" +
": imageEditorViewModel.calculatedHeight() + \'px\' }\"");

WriteLiteral(" />\n                </div>\n");

            
            #line 59 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 62 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_PublicUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                        <div");

WriteLiteral(" class=\"bcms-edit-file-info\"");

WriteLiteral(">\n                            <input");

WriteLiteral(" class=\"bcms-field-text bcms-editor-selectable-field-box\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3634), Tuple.Create("\"", 3652)
            
            #line 64 "..\..\Views\Images\ImageEditor.cshtml"
                               , Tuple.Create(Tuple.Create("", 3642), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 3642), false)
);

WriteLiteral(" readonly=\"readonly\"");

WriteLiteral(" />\n                        </div>\n                    </div>\n                   " +
" <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_Caption);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

WriteLiteral("                        ");

            
            #line 69 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Caption_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 71 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextBoxFor(f => f.Caption, new { @class = "bcms-field-text", @id = "Caption", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                            ");

            
            #line 72 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Caption));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n                    </div>\n                    <d" +
"iv");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(" data-bind=\"with: titleEditorViewModel\"");

WriteLiteral(" id=\"bcms-image-title-editor-box\"");

WriteLiteral(">\n                        <b>");

            
            #line 76 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_ImageName_Title);

            
            #line default
            #line hidden
WriteLiteral(":</b><div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" data-bind=\"text: oldTitle()\"");

WriteLiteral("></div>\n                        <a");

WriteLiteral(" class=\"bcms-file-link\"");

WriteLiteral(" data-bind=\"click: open, visible: !isOpened()\"");

WriteLiteral(">");

            
            #line 77 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                           Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                        <div");

WriteLiteral(" class=\"bcms-file-edit\"");

WriteLiteral(" data-bind=\"style: { \'display\': isOpened() ? \'block\' : \'none\' }\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\Images\ImageEditor.cshtml"
                                                        Write(MediaGlobalization.ImageEditor_Dialog_ImageTitle_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("                                ");

            
            #line 81 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.Title, new
                       {
                           @class = "bcms-field-text",
                           @id = "bcms-image-title-editor",
                           @data_bind = "value: title, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: {change: $parent.onValueChange}"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                                ");

            
            #line 87 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\n                            </div>\n                            <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: save\"");

WriteLiteral(">");

            
            #line 89 "..\..\Views\Images\ImageEditor.cshtml"
                                                                             Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: close\"");

WriteLiteral(">");

            
            #line 90 "..\..\Views\Images\ImageEditor.cshtml"
                                                                             Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                        </div>\n                    </div>\n                " +
"    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(">\n                        <b>");

            
            #line 94 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_FileSize);

            
            #line default
            #line hidden
WriteLiteral(":</b>\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" id=\"image-file-size\"");

WriteLiteral(">");

            
            #line 95 "..\..\Views\Images\ImageEditor.cshtml"
                                                                       Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    </div>\n\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(" data-bind=\"visible: imageEditorViewModel.enableCrop\"");

WriteLiteral(">\n                        <b>");

            
            #line 99 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_CroppedDimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" id=\"image-file-size\"");

WriteLiteral(" data-bind=\"text: imageEditorViewModel.croppedWidthAndHeight()\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                      Write(Model.CroppedWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 100 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                                            Write(Model.CroppedHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    </div>\n                    <div");

WriteLiteral(" class=\"bcms-file-info-text\"");

WriteLiteral(" data-bind=\"with: imageEditorViewModel\"");

WriteLiteral(" id=\"bcms-image-dimensions-editor-box\"");

WriteLiteral(">\n                        <b>");

            
            #line 103 "..\..\Views\Images\ImageEditor.cshtml"
                      Write(MediaGlobalization.ImageEditor_Dialog_Dimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\n                        <div");

WriteLiteral(" class=\"bcms-editing-text\"");

WriteLiteral(" data-bind=\"text: widthAndHeight()\"");

WriteLiteral(">");

            
            #line 104 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                     Write(Model.ImageWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");

            
            #line 104 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                         Write(Model.ImageHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    <a");

WriteLiteral(" class=\"bcms-file-link\"");

WriteLiteral(" data-bind=\"click: open, visible: !isOpened() && $parent.imageEditorViewModel.ima" +
"geType() == 1\"");

WriteLiteral(">");

            
            #line 105 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                        Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                        <div");

WriteLiteral(" class=\"bcms-file-edit\"");

WriteLiteral(" data-bind=\"style: { \'display\': isOpened() ? \'block\' : \'none\' }\"");

WriteLiteral(">\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Images\ImageEditor.cshtml"
                                                        Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n                            <span>");

            
            #line 109 "..\..\Views\Images\ImageEditor.cshtml"
                             Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Width);

            
            #line default
            #line hidden
WriteLiteral(":</span>\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("                                ");

            
            #line 111 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.ImageWidth, new
                            {
                                @class = "bcms-field-text",
                                @id = "image-width",
                                @data_bind = "value: width, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeHeight }"
                            }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                                ");

            
            #line 117 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.ImageWidth));

            
            #line default
            #line hidden
WriteLiteral("\n                            </div>\n                            <span>");

            
            #line 119 "..\..\Views\Images\ImageEditor.cshtml"
                             Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Height);

            
            #line default
            #line hidden
WriteLiteral(":</span>\n                            <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\n");

WriteLiteral("                                ");

            
            #line 121 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.TextBoxFor(f => f.ImageHeight, new
                            {
                                @class = "bcms-field-text",
                                @id = "image-height",
                                @data_bind = "value: height, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeWidth }"
                            }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                                ");

            
            #line 127 "..\..\Views\Images\ImageEditor.cshtml"
                           Write(Html.BcmsValidationMessageFor(f => f.ImageHeight));

            
            #line default
            #line hidden
WriteLiteral("\n                            </div>\n                            <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" data-bind=\"click: save\"");

WriteLiteral(">");

            
            #line 129 "..\..\Views\Images\ImageEditor.cshtml"
                                                                             Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(" data-bind=\"click: close\"");

WriteLiteral(">");

            
            #line 130 "..\..\Views\Images\ImageEditor.cshtml"
                                                                             Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                            <a");

WriteLiteral(" data-bind=\"click: restoreOriginalSize\"");

WriteLiteral(">");

            
            #line 131 "..\..\Views\Images\ImageEditor.cshtml"
                                                                 Write(MediaGlobalization.ImageEditor_Dialog_RestoreOriginalSize_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                        </div>\n                    </div>\n                </" +
"div>\n");

            
            #line 135 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-file-alignment\"");

WriteLiteral(">\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 137 "..\..\Views\Images\ImageEditor.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_AligmentTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\n                    \n                    <div");

WriteLiteral(" class=\"bcms-alignment-controls\"");

WriteLiteral(">\n                        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 9417), Tuple.Create("\"", 9514)
, Tuple.Create(Tuple.Create("", 9425), Tuple.Create("bcms-align-center", 9425), true)
            
            #line 140 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9442), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Center ? "-active" : string.Empty
            
            #line default
            #line hidden
, 9442), false)
);

WriteLiteral(">\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 9582), Tuple.Create("\"", 9620)
            
            #line 141 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9590), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Center
            
            #line default
            #line hidden
, 9590), false)
);

WriteLiteral(" ");

            
            #line 141 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                     Write(Model.ImageAlign == MediaImageAlign.Center ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\n                        </div>\n              " +
"          <div");

WriteAttribute("class", Tuple.Create(" class=\"", 9789), Tuple.Create("\"", 9882)
, Tuple.Create(Tuple.Create("", 9797), Tuple.Create("bcms-align-left", 9797), true)
            
            #line 143 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9812), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Left ? "-active" : string.Empty
            
            #line default
            #line hidden
, 9812), false)
);

WriteLiteral(">\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 9950), Tuple.Create("\"", 9986)
            
            #line 144 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 9958), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Left
            
            #line default
            #line hidden
, 9958), false)
);

WriteLiteral(" ");

            
            #line 144 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                   Write(Model.ImageAlign == MediaImageAlign.Left ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\n                        </div>\n              " +
"          <div");

WriteAttribute("class", Tuple.Create(" class=\"", 10153), Tuple.Create("\"", 10248)
, Tuple.Create(Tuple.Create("", 10161), Tuple.Create("bcms-align-right", 10161), true)
            
            #line 146 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 10177), Tuple.Create<System.Object, System.Int32>(Model.ImageAlign == MediaImageAlign.Right ? "-active" : string.Empty
            
            #line default
            #line hidden
, 10177), false)
);

WriteLiteral(">\n                            <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ImageAlign\"");

WriteAttribute("value", Tuple.Create(" value=\"", 10316), Tuple.Create("\"", 10353)
            
            #line 147 "..\..\Views\Images\ImageEditor.cshtml"
, Tuple.Create(Tuple.Create("", 10324), Tuple.Create<System.Object, System.Int32>((int)MediaImageAlign.Right
            
            #line default
            #line hidden
, 10324), false)
);

WriteLiteral(" ");

            
            #line 147 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                    Write(Model.ImageAlign == MediaImageAlign.Right ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\n                        </div>\n              " +
"      </div>\n\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 152 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

WriteLiteral("                        ");

            
            #line 153 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Description_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\n                        <div");

WriteLiteral(" class=\"bcms-textarea-box\"");

WriteLiteral(">\n");

WriteLiteral("                            ");

            
            #line 155 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextAreaFor(f => f.Description, new { @class = "bcms-field-textarea", @id = "Description", @style = "width: 380px;", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                            ");

            
            #line 156 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Description));

            
            #line default
            #line hidden
WriteLiteral("\n                        </div>\n                    </div>\n                </div>" +
"\n");

            
            #line 160 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-categories-box-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 162 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 164 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-categories-box-holder\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 166 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 168 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"bcms-media-reupload\"");

WriteLiteral(" data-bind=\"click: reupload\"");

WriteLiteral(">");

            
            #line 169 "..\..\Views\Images\ImageEditor.cshtml"
                                                                        Write(MediaGlobalization.ImageEditor_Dialog_Reupload_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 170 "..\..\Views\Images\ImageEditor.cshtml"

                
            
            #line default
            #line hidden
            
            #line 171 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 171 "..\..\Views\Images\ImageEditor.cshtml"
                                    
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n    </div>\n</div>\n");

        }
    }
}
#pragma warning restore 1591
