function _createForOfIteratorHelperLoose(o, allowArrayLike) { var it = typeof Symbol !== "undefined" && o[Symbol.iterator] || o["@@iterator"]; if (it) return (it = it.call(o)).next.bind(it); if (Array.isArray(o) || (it = _unsupportedIterableToArray(o)) || allowArrayLike && o && typeof o.length === "number") { if (it) o = it; var i = 0; return function () { if (i >= o.length) return { done: true }; return { done: false, value: o[i++] }; }; } throw new TypeError("Invalid attempt to iterate non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method."); }

function _unsupportedIterableToArray(o, minLen) { if (!o) return; if (typeof o === "string") return _arrayLikeToArray(o, minLen); var n = Object.prototype.toString.call(o).slice(8, -1); if (n === "Object" && o.constructor) n = o.constructor.name; if (n === "Map" || n === "Set") return Array.from(o); if (n === "Arguments" || /^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(n)) return _arrayLikeToArray(o, minLen); }

function _arrayLikeToArray(arr, len) { if (len == null || len > arr.length) len = arr.length; for (var i = 0, arr2 = new Array(len); i < len; i++) { arr2[i] = arr[i]; } return arr2; }

function ownKeys(object, enumerableOnly) { var keys = Object.keys(object); if (Object.getOwnPropertySymbols) { var symbols = Object.getOwnPropertySymbols(object); if (enumerableOnly) { symbols = symbols.filter(function (sym) { return Object.getOwnPropertyDescriptor(object, sym).enumerable; }); } keys.push.apply(keys, symbols); } return keys; }

function _objectSpread(target) { for (var i = 1; i < arguments.length; i++) { var source = arguments[i] != null ? arguments[i] : {}; if (i % 2) { ownKeys(Object(source), true).forEach(function (key) { _defineProperty(target, key, source[key]); }); } else if (Object.getOwnPropertyDescriptors) { Object.defineProperties(target, Object.getOwnPropertyDescriptors(source)); } else { ownKeys(Object(source)).forEach(function (key) { Object.defineProperty(target, key, Object.getOwnPropertyDescriptor(source, key)); }); } } return target; }

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

import parseProperties from './parseProperties';
import parseFilePaths from './parseFilePaths';
import parseStyles from './parseStyles';
import parseSharedStrings from './parseSharedStrings';
import parseSheet from './parseSheet';
import getData from './getData'; // For an introduction in reading `*.xlsx` files see "The minimum viable XLSX reader":
// https://www.brendanlong.com/the-minimum-viable-xlsx-reader.html

/**
 * Reads an (unzipped) XLSX file structure into a 2D array of cells.
 * @param  {object} contents - A list of XML files inside XLSX file (which is a zipped directory).
 * @param  {number?} options.sheet - Workbook sheet id (`1` by default).
 * @param  {string?} options.dateFormat - Date format, e.g. "mm/dd/yyyy". Values having this format template set will be parsed as dates.
 * @param  {object} contents - A list of XML files inside XLSX file (which is a zipped directory).
 * @return {object} An object of shape `{ data, cells, properties }`. `data: string[][]` is an array of rows, each row being an array of cell values. `cells: string[][]` is an array of rows, each row being an array of cells. `properties: object` is the spreadsheet properties (e.g. whether date epoch is 1904 instead of 1900).
 */

export default function readXlsx(contents, xml) {
  var options = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : {};

  if (!options.sheet) {
    options = _objectSpread({
      sheet: 1
    }, options);
  } // Some Excel editors don't want to use standard naming scheme for sheet files.
  // https://github.com/tidyverse/readxl/issues/104


  var filePaths = parseFilePaths(contents['xl/_rels/workbook.xml.rels'], xml); // Default file path for "shared strings": "xl/sharedStrings.xml".

  var values = filePaths.sharedStrings ? parseSharedStrings(contents[filePaths.sharedStrings], xml) : []; // Default file path for "styles": "xl/styles.xml".

  var styles = filePaths.styles ? parseStyles(contents[filePaths.styles], xml) : {};
  var properties = parseProperties(contents['xl/workbook.xml'], xml); // A feature for getting the list of sheets in an Excel file.
  // https://github.com/catamphetamine/read-excel-file/issues/14

  if (options.getSheets) {
    return properties.sheets.map(function (_ref) {
      var name = _ref.name;
      return {
        name: name
      };
    });
  } // Find the sheet by name, or take the first one.


  var sheetId = getSheetId(options.sheet, properties.sheets); // If the sheet wasn't found then throw an error.
  // Example: "xl/worksheets/sheet1.xml".

  if (!sheetId || !filePaths.sheets[sheetId]) {
    throw createSheetNotFoundError(options.sheet, properties.sheets);
  } // Parse sheet data.


  var sheet = parseSheet(contents[filePaths.sheets[sheetId]], xml, values, styles, properties, options); // Get spreadsheet data.

  var data = getData(sheet, options); // Can return properties, if required.

  if (options.properties) {
    return {
      data: data,
      properties: properties
    };
  } // Return spreadsheet data.


  return data;
}

function getSheetId(sheet, sheets) {
  if (typeof sheet === 'number') {
    var _sheet = sheets[sheet - 1];
    return _sheet && _sheet.relationId;
  }

  for (var _iterator = _createForOfIteratorHelperLoose(sheets), _step; !(_step = _iterator()).done;) {
    var _sheet2 = _step.value;

    if (_sheet2.name === sheet) {
      return _sheet2.relationId;
    }
  }
}

function createSheetNotFoundError(sheet, sheets) {
  var sheetsList = sheets && sheets.map(function (sheet, i) {
    return "\"".concat(sheet.name, "\" (#").concat(i + 1, ")");
  }).join(', ');
  return new Error("Sheet ".concat(typeof sheet === 'number' ? '#' + sheet : '"' + sheet + '"', " not found in the *.xlsx file.").concat(sheets ? ' Available sheets: ' + sheetsList + '.' : ''));
}
//# sourceMappingURL=readXlsx.js.map