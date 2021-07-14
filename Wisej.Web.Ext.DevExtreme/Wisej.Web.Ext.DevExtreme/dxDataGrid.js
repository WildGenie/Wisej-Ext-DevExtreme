//# sourceURL=wisej.web.ext.DevExtremeWidget.dxDataGrid.js

///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

	if (options.columns) {
		for (var i = 0; i < options.columns.length; i++) {
			if (options.columns[i].cellTemplate) 
				options.columns[i].cellTemplate = this.initFunction(options.columns[i].cellTemplate);
		}
	}

	if (options.masterDetail) {
		options.masterDetail.template = this.initFunction(options.masterDetail.template);
	}

	if (options.stateStoring) {
		if (options.stateStoring.customLoad)
			options.stateStoring.customLoad = this.initFunction(options.stateStoring.customLoad);

		if (options.stateStoring.customSave)
			options.stateStoring.customSave = this.initFunction(options.stateStoring.customSave);

    }
};

// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {

	switch (args.type) {

		case "cellClick":
			return {
				columnIndex: args.columnIndex,
				rowIndex: args.rowIndex,
				value: args.value
			};

		case "keyDown":
			return {
				key: args.event.key,
				altKey: args.event.altKey,
				keyCode: args.event.keyCode,
				ctrlKey: args.event.ctrlKey,
				metaKey: args.event.metaKey,
				shiftKey: args.event.shiftKey
			};

		case "initNewRow":
			return {
				data: args.data
			};

		case "rowClick":
			return {
				columns: args.columns,
				data: args.data,
				groupIndex: args.groupIndex,
				handled: args.handled,
				isExpanded: args.isExpanded,
				isNewRow: args.isNewRow,
				isSelected: args.isSelected,
				key: args.key,
				rowIndex: args.rowIndex,
				rowType: args.rowType,
				values: args.values
			};

		case "rowInserted":
			return {
				data: args.data,
				key: args.key
			};

		case "rowPrepared":
			return {
				columns: args.columns,
				data: args.data,
				groupIndex: args.groupIndex,
				isExpanded: args.isExpanded,
				isNewRow: args.isNewRow,
				isSelected: args.isSelected,
				key: args.key,
				rowIndex: args.rowIndex,
				rowType: args.rowType,
				values: args.values
			};

		case "selectionChanged":
			return {
				currentDeselectedRowKeys: args.currentDeselectedRowKeys,
				currentSelectedRowKeys: args.currentSelectedRowKeys,
				selectedRowKeys: args.selectedRowKeys
			};

	}
};
