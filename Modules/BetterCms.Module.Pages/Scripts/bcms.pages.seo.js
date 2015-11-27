﻿/*jslint unparam: true, white: true, browser: true, devel: true */
/*global bettercms */

bettercms.define('bcms.pages.seo', ['bcms.jquery', 'bcms', 'bcms.modal', 'bcms.messages', 'bcms.dynamicContent', 'bcms.redirect'],
    function ($, bcms, modal, messages, dynamicContent, redirect) {
    'use strict';

    var seo = {},
        classes = {
            editSeoDialogClass: 'bcms-modal-edit-seo'
        },
        selectors = {
            pageUrlPath: '#bcms-page-permalink-info',
            editPageUrlLink: '#bcms-editseo-editurlpath',
            editUrlPathBox: '.bcms-js-edit-box',
            editUrlSave: '#bcms-editseo-editurlpath-save',
            editUrlCancel: '#bcms-editseo-editurlpath-cancel, .bcms-js-edit-box .bcms-tip-close',
            editUrlTextBox: '.bcms-js-url-path',
            editSeoForm: 'form:first',
            editSeoCloseInfoMessage: '#bcms-seo-closeinfomessage',
            editSeoInfoMessageBox: '.bcms-warning-messages'
        },
        links = {
            loadEditSeoDialogUrl: null
        },
        globalization = {
            editSeoDialogTitle: null            
        };

    /**
    * Assign objects to module.
    */
    seo.links = links;
    seo.globalization = globalization;

    /**
    * Sets edit page path box visibility.
    */
    function setEditPagePathBoxVisibility(dialog, visible) {
        if (visible) {
            dialog.container.find(selectors.editUrlPathBox).show();
            dialog.container.find(selectors.editUrlTextBox).focus();
        } else {
            dialog.container.find(selectors.editUrlTextBox).blur();
            dialog.container.find(selectors.editUrlPathBox).hide();
        }
    }
    
    /**
    * Initializes EditSeo dialog events.
    */
    seo.initEditSeoDialogEvents = function (editSeoDialog) {       
        editSeoDialog.container.find(selectors.editPageUrlLink).on('click', function () {
            setEditPagePathBoxVisibility(editSeoDialog, true);
        });

        editSeoDialog.container.find(selectors.editUrlSave).on('click', function () {
            seo.saveEditUrlPath(editSeoDialog);
        });

        editSeoDialog.container.find(selectors.editUrlCancel).on('click', function () {            
            seo.cancelEditUrlPath(editSeoDialog);
        });

        editSeoDialog.container.find(selectors.editSeoCloseInfoMessage).on('click', function () {
            editSeoDialog.container.find(selectors.editSeoInfoMessageBox).hide();
        });

        editSeoDialog.container.find(selectors.editSeoForm).on('submit', function () {
            if (!editSeoDialog.container.find(selectors.editUrlTextBox).valid()) {
                setEditPagePathBoxVisibility(editSeoDialog, true);
            }
        });

        bcms.preventInputFromSubmittingForm(editSeoDialog.container.find(selectors.editUrlTextBox), {
            preventedEnter: function () {
                editSeoDialog.container.find(selectors.editUrlTextBox).blur();
                seo.saveEditUrlPath(editSeoDialog);
            },
            preventedEsc: function () {
                editSeoDialog.container.find(selectors.editUrlTextBox).blur();
                seo.cancelEditUrlPath(editSeoDialog);
            }
        });
    };
    
    /**
   * Shows edit Url path box on EditSeo dialog.
   **/
    seo.saveEditUrlPath = function (editSeoDialog) {
        var editUrlTextBox = editSeoDialog.container.find(selectors.editUrlTextBox),
            isValidEditUrlTextBox = true;

        if ($.isFunction(editUrlTextBox.valid)) {
            isValidEditUrlTextBox = editUrlTextBox.valid();
        }
        
        if (isValidEditUrlTextBox)
        {
            editSeoDialog.container.find(selectors.pageUrlPath).text(editUrlTextBox.val());
            setEditPagePathBoxVisibility(editSeoDialog, false);
        }
    };

    /**
    * Hides edit Url path box on EditSeo dialog.
    **/
    seo.cancelEditUrlPath = function (editSeoDialog) {
        var prevPath = editSeoDialog.container.find(selectors.pageUrlPath).text();
        editSeoDialog.container.find(selectors.editUrlTextBox).val(prevPath);        
        setEditPagePathBoxVisibility(editSeoDialog, false);
    };
    
    /**
    * Loads edit SEO dialog.
    */
    seo.openEditSeoDialog = function() {
        modal.open({
            title: globalization.editSeoDialogTitle,
            cssClass: classes.editSeoDialogClass,
            onLoad: function (dialog) {
                var url = $.format(links.loadEditSeoDialogUrl, bcms.pageId);
                dynamicContent.bindDialog(dialog, url, {
                    contentAvailable : function () {
                        seo.initEditSeoDialogEvents(dialog);
                    },
                                   
                    postComplete: function (data) {
                        if (data.Data && data.Data.PageUrlPath) {
                            redirect.RedirectWithAlert(data.Data.PageUrlPath);
                        }
                    }
                });
                
            }            
        });
    };   
    
    /**
    * Initializes page module.
    */
    seo.init = function () {
        bcms.logger.debug('Initializing bcms.pages.seo module.');
    };
    
    /**
    * Register initialization
    */
    bcms.registerInit(seo.init);
    
    return seo;
});
