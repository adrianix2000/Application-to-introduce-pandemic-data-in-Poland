using Covid_Data.DataLayer.DataModels;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_Data.DataLayer
{
    public class ExcelMenager
    {
        public async Task WriteToExcel(List<CountryClass> countries, string FilePath, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(FilePath);

            await SaveExcelFile(countries, file, sheetName);
        }

        public async Task WriteToExcel2(List<OneDayOfPoland> PolandDays, string FilePath, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(FilePath);

            await SaveExcelFile2(PolandDays, file, sheetName);
        }

        private static async Task SaveExcelFile(List<CountryClass> countries, FileInfo file, string sheetName)
        {
            DeleteIfExists(file);

            using (var package = new ExcelPackage(file))
            {
                //package.Dispose();
                var ws = package.Workbook.Worksheets.Add(sheetName);

                var range = ws.Cells["A4"].LoadFromCollection(countries, true);
                range.AutoFitColumns();

                ws.Cells["A3"].Value = sheetName;
                ws.Cells["A3:C3"].Merge = true;

                ws.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(3).Style.Font.Size = 24;
                ws.Row(3).Style.Font.Color.SetColor(Color.Blue);

                ws.Row(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(4).Style.Font.Bold = true;
                ws.Column(5).Width = 20;

                await package.SaveAsync();
            }
         
        }


        private static async Task SaveExcelFile2(List<OneDayOfPoland> countries, FileInfo file, string sheetName)
        {
            DeleteIfExists(file);

            using (var package = new ExcelPackage(file))
            {
                //package.Dispose();
                var ws = package.Workbook.Worksheets.Add(sheetName);

                var range = ws.Cells["A4"].LoadFromCollection(countries, true);
                range.AutoFitColumns();

                ws.Cells["A3"].Value = sheetName;
                ws.Cells["A3:C3"].Merge = true;

                ws.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(3).Style.Font.Size = 24;
                ws.Row(3).Style.Font.Color.SetColor(Color.Blue);

                ws.Row(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Row(4).Style.Font.Bold = true;
                ws.Column(5).Width = 20;

                await package.SaveAsync();
            }

        }



        private static void DeleteIfExists(FileInfo file)
        {
            if(file.Exists)
            {
                file.Delete();
            }
        }
    }
}
