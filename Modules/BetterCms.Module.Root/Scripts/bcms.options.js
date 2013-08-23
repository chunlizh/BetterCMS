﻿/*jslint unparam: true, white: true, browser: true, devel: true */
/*global define, console */

bettercms.define('bcms.options', ['bcms.jquery', 'bcms', 'bcms.ko.extenders', 'bcms.ko.grid', 'bcms.datepicker'],
    function ($, bcms, ko, kogrid) {
        'use strict';

        var options = {},
            selectors = {
                datePickers: '.bcms-datepicker',
                datePickerBoxes: '.ui-datepicker-trigger, .ui-datepicker'
            },
            links = {},
            globalization = {
                deleteOptionConfirmMessage: null,
                optionTypeText: null,
                optionTypeInteger: null,
                optionTypeBoolean: null,
                optionTypeDateTime: null,
                optionTypeFloat: null,
                datePickerTooltipTitle: null,
                optionValidationMessage: null
            },
            optionTypes = {
                textType: 1,
                integerType: 2,
                floatType: 3,
                dateTimeType: 4,
                boolType: 5
            },
            rowId = 0;

        /**
        * Assign objects to module.
        */
        options.links = links;
        options.globalization = globalization;
        options.selectors = selectors;

        /**
        * Options list view model
        */
        var OptionsListViewModel = (function (_super) {

            bcms.extendsClass(OptionsListViewModel, _super);

            function OptionsListViewModel(container, items) {
                _super.call(this, container, null, items, null);
            };

            OptionsListViewModel.prototype.createItem = function (item) {
                var newItem = new OptionViewModel(this, item);
                
                return newItem;
            };

            return OptionsListViewModel;

        })(kogrid.ListViewModel);

        var OptionValuesListViewModel = (function (_super) {
            bcms.extendsClass(OptionValuesListViewModel, _super);
            
            function OptionValuesListViewModel(container, items) {
                _super.call(this, container, items);
            };

            OptionValuesListViewModel.prototype.createItem = function (item) {
                var newItem = new OptionValueViewModel(this, item);

                return newItem;
            };

            OptionValuesListViewModel.prototype.onAfterNewItemAdded = function (item) {
                if (item.canEditOption !== false && item.key.domElement) {
                    $(item.key.domElement).focus();
                }
            };

            return OptionValuesListViewModel;
        })(OptionsListViewModel);

        /**
        * Option view model
        */
        var OptionViewModel = (function (_super) {
        
            bcms.extendsClass(OptionViewModel, _super);

            function OptionViewModel(parent, item) {
                _super.call(this, parent, item);

                var self = this;

                // Main values
                self.key = ko.observable().extend({ required: "", maxLength: { maxLength: ko.maxLength.name } });
                self.defaultValue = ko.observable().extend({ optionValue: { self: self } }).extend({ notify: 'always' });
                self.value = ko.observable().extend({ optionValue: { self: self } }).extend({ notify: 'always' });
                self.type = ko.observable();

                // Additional values
                self.typeName = ko.observable();
                self.lastType = null;
                self.editableValue = self.getValueField();
                self.rowId = null;

                self.optionTypes = [];
                self.optionTypes.push({ id: optionTypes.textType, name: globalization.optionTypeText });
                self.optionTypes.push({ id: optionTypes.integerType, name: globalization.optionTypeInteger });
                self.optionTypes.push({ id: optionTypes.floatType, name: globalization.optionTypeFloat });
                self.optionTypes.push({ id: optionTypes.dateTimeType, name: globalization.optionTypeDateTime });
                self.optionTypes.push({ id: optionTypes.boolType, name: globalization.optionTypeBoolean });
            
                self.registerFields(self.key, self.defaultValue, self.value, self.type);

                self.getOptionTypeName = function() {
                    var i,
                        type = self.type();

                    for (i = 0; i < self.optionTypes.length; i++) {
                        if (self.optionTypes[i].id == type) {
                            return self.optionTypes[i].name;
                        }
                    }

                    return '';
                };

                self.type.subscribe(function (newType) {
                    var oldType = self.lastType;

                    // Entering boolean mode
                    if (oldType == optionTypes.boolType) {
                        self.editableValue('');
                    }
                    
                    // Leaving boolean mode
                    if (newType == optionTypes.boolType) {
                        if (self.editableValue() !== 'true' && self.editableValue() !== true) {
                            self.editableValue(false);
                        }
                    }

                    // Save new value
                    self.lastType = newType;

                    // Set type name
                    self.typeName(self.getOptionTypeName());
                    
                    // Notify value to be re-validated
                    self.editableValue(self.editableValue());
                });

                self.initDatePickers = function () {
                    if (!self.datePickersRendered) {
                        self.datePickersRendered = true;

                        var datePickerOpts = {
                            onSelect: function(newDate) {
                                self.isSelected = true;
                                self.editableValue(newDate);
                            }
                        },
                            row = $('#' + self.rowId),
                            datePickerBoxes,
                            datePickers = row.find(selectors.datePickers);

                        datePickers.initializeDatepicker(globalization.datePickerTooltipTitle, datePickerOpts);

                        datePickerBoxes = row.find(selectors.datePickerBoxes);
                        datePickerBoxes.on('click', self.onItemSelect);
                        datePickerBoxes.on('focus', self.onItemSelect);
                        datePickerBoxes.on('blur', self.onBlurField);
                    }
                };
                
                // Set values
                self.key(item.OptionKey);
                self.defaultValue(item.OptionDefaultValue);
                self.value(item.OptionValue);
                self.type(item.Type);
                self.canEditOption = item.CanEditOption;
                self.disableFieldsEditing();

                self.isActive.subscribe(function(newValue) {
                    if (!newValue) {
                        self.datePickersRendered = false;
                    }
                });
                
                self.type.subscribe(function (newValue) {
                    if (newValue != optionTypes.dateTimeType) {
                        self.datePickersRendered = false;
                    }
                });
            };

            OptionViewModel.prototype.getValueField = function() {
                return this.defaultValue;
            };

            OptionViewModel.prototype.getDeleteConfirmationMessage = function () {
                return $.format(globalization.deleteOptionConfirmMessage, this.key());
            };

            OptionViewModel.prototype.disableFieldsEditing = function () {
                return;
            };
            
            OptionViewModel.prototype.getRowId = function () {
                if (!this.rowId) {
                    this.rowId = 'bcms-option-row-' + rowId++;
                }
                return this.rowId;
            };

            return OptionViewModel;

        })(kogrid.ItemViewModel);

        /**
        * Option value view model
        */
        var OptionValueViewModel = (function (_super) {
            bcms.extendsClass(OptionValueViewModel, _super);

            function OptionValueViewModel(parent, item) {
                _super.call(this, parent, item);
            }

            function disableFieldEditing(field) {
                if (!field.editingIsDisabled) {
                    field.editingIsDisabled = ko.observable();
                }

                field.editingIsDisabled(true);
            }

            OptionValueViewModel.prototype.getValueField = function () {
                return this.value;
            };

            OptionValueViewModel.prototype.disableFieldsEditing = function () {
                if (this.canEditOption === false) {
                    disableFieldEditing(this.key);
                    disableFieldEditing(this.type);

                    if (!this.deletingIsDisabled) {
                        this.deletingIsDisabled = ko.observable();
                    }
                    this.deletingIsDisabled(true);
                }
            };

            return OptionValueViewModel;
        })(OptionViewModel);

        /**
        * Creates options list view model
        */
        options.createOptionsViewModel = function(container, items) {
            return new OptionsListViewModel(container, items);
        };

        /**
        * Creates option values list view model
        */
        options.createOptionValuesViewModel = function (container, items) {
            return new OptionValuesListViewModel(container, items);
        };

        ko.extenders.optionValue = function (target, opts) {
            var ruleName = 'optionValue',
                self = opts.self;

            return ko.extenders.koValidationExtender(ruleName, target, function (newValue) {
                if (!self.type) {
                    return;
                }

                var type = self.type(),
                    mustBeNumber = type == optionTypes.floatType || type == optionTypes.integerType,
                    hasError = mustBeNumber && newValue && isNaN(Number(newValue)),
                    showMessage,
                    regExp;
                
                if (!hasError && newValue && type == optionTypes.integerType) {
                    regExp = new RegExp(/^-?\d*$/);
                    hasError = !regExp.test(newValue);
                }

                showMessage = hasError ? $.format(globalization.optionValidationMessage, self.key(), self.getOptionTypeName()) : '';

                target.validator.setError(ruleName, hasError, showMessage);
            });
        };

        /**
        * Initializes bcms options module.
        */
        options.init = function () {
            console.log('Initializing bcms.options module.');
        };

        /**
        * Register initialization
        */
        bcms.registerInit(options.init);

        return options;
});
