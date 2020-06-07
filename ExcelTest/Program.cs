using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using Npoi.Mapper;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ExcelTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var objects = new List<object>
            {
                new
                {
                    Name = "Ali",
                    Age = 25,
                    Phone = "09124586378"
                }
            };

            await Task.Factory.StartNew(() =>
             {
                 //using (var fileStream = new FileStream("E:\\aaa.xlsx", FileMode.Create))
                 using (var memoryStream = new MemoryStream())
                 {
                     IWorkbook workbook = new XSSFWorkbook();

                     var sheet = workbook.CreateSheet("sheet0");

                     var row0 = sheet.CreateRow(0);
                     var cell0 = row0.CreateCell(0);
                     cell0.SetCellValue("کد رهگیری");

                     var row1 = sheet.CreateRow(1);
                     var cell1 = row1.CreateCell(0);
                     cell1.SetCellValue(Guid.NewGuid().ToString("N"));
                     
                     workbook.Write(memoryStream);
                 }

                 using (var memoryStream = new MemoryStream())
                 {
                     var mapper = new Mapper();
                     //mapper.Save("E:\\aaa.xlsx", objects, "sheet1", overwrite: false, xlsx: true);
                     mapper.Save(memoryStream, objects, "sheet1", overwrite: false, xlsx: true);
                 }
                 
             });

            Console.WriteLine("Done!");
        }
    }
}
