﻿using MISA.WebFresher052023.Application;
using MISA.WebFresher052023.Domain.Resources.Common;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Infrastructure
{
    public abstract class ExcelCore<TEntityDto> : IExcelCore<TEntityDto>
    {
        protected string SheetName { get; set; } = "Sheet 1";
        protected string SheetTitle { get; set; } = "Sheet title";

        /// <summary>
        /// Xử lý xuất file Excel
        /// </summary>
        /// <returns>Mảng bytes của file Excel</returns>
       
        public byte[] ExportToExcelAsync(IEnumerable<TEntityDto> entityDtos, IEnumerable<string> columns)
        {
            // Tạo luồng download file
            var stream = new MemoryStream();

            using var excelPackage = new ExcelPackage(stream);

            // Định nghĩa một trang tính
            var worksheet = excelPackage.Workbook.Worksheets.Add(SheetName);

            // Định nghĩa style chung
            var cellStyle = excelPackage.Workbook.Styles.CreateNamedStyle("CellStyle");
            cellStyle.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            cellStyle.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            cellStyle.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            cellStyle.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            cellStyle.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            cellStyle.Style.Font.Name = "Arial";

            // Tổng số cột
            var properties = typeof(TEntityDto).GetProperties();
            var bonusOrderCol = 1;
            var totalColumns = columns.ToList().Count + bonusOrderCol;

            // Tạo kiểu cho tiêu đề
            worksheet.Cells["A1"].Value = SheetTitle;
            using var titleRange = worksheet.Cells[1, 1, 1, totalColumns];
            titleRange.Merge = true;
            titleRange.Style.Font.Size = 16;
            titleRange.Style.Font.Name = "Arial";
            titleRange.Style.Font.Bold = true;
            titleRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            titleRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Rows[1].Height = 28;

            // Tên các cột theo danh sách và thứ tự được cung cấp
            var headerRow = 3;
            var colPos = 2;
            worksheet.Cells[headerRow, 1].Value = CommonResource.Order;

            foreach (var column in columns)
            {
                foreach (var property in properties)
                {
                    if (property.Name.ToLower() == column.ToLower())
                    {
                        worksheet.Cells[headerRow, colPos].Value = AttributeGetter.GetDisplayAttribute(property) + property.PropertyType.Name;

                        colPos++;

                        break;
                    }
                }
            }

            // Style cho tên cột
            using var columnNameRange = worksheet.Cells[headerRow, 1, headerRow, totalColumns];
            columnNameRange.StyleName = cellStyle.Name;
            columnNameRange.Style.Font.Bold = true;
            columnNameRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            columnNameRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
            columnNameRange.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
            worksheet.Rows[headerRow].Height = 28;

            // Nội dung
            var currentRow = 4;
            var order = 1;
            foreach (var entityDto in entityDtos)
            {
                var currentCol = 2;
                worksheet.Cells[currentRow, 1].Value = order;

                foreach (var column in columns)
                {
                    foreach (var property in properties)
                    {
                        if (property.Name.ToLower() == column.ToLower())
                        {
                            worksheet.Cells[currentRow, currentCol].Value = property.GetValue(entityDto);

                            currentCol++;
                        }
                    }
                }

                // Tạo kiểu cho các ô và các hàng
                worksheet.Cells[currentRow, 1, currentRow, totalColumns].StyleName = cellStyle.Name;
                worksheet.Cells.AutoFitColumns();
                worksheet.Rows[currentRow].Height = 28;

                currentRow++;
                order++;
            }

            excelPackage.Save();

            stream.Position = 0;

            var bytes = stream.ToArray();

            return bytes;
        }

        /// <summary>
        /// Xử lý nhập file Excel
        /// </summary>
        /// <returns>Mảng bytes của file Excel</returns>
       
        public void ImportFromExcelAsync()
        {
            throw new NotImplementedException();
        }
    }
}
