using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Vykazy.Model
{
    public static class ExcelGenerator
    {
        public static void HorizontalniZarovnani(Excel._Worksheet ws, string from, string to, string type)
        {
            switch (type)
            {
                case "center":
                    ws.get_Range(from, to).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    break;
                case "left":
                    ws.get_Range(from, to).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    break;
                case "right":
                    ws.get_Range(from, to).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    break;
                default:
                    break;
            }
        }
        public static void VertikalniZarovnani(Excel._Worksheet ws, string from, string to, string type)
        {
            switch (type)
            {
                case "center":
                    ws.get_Range(from, to).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    break;
                case "bottom":
                    ws.get_Range(from, to).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom;
                    break;
                case "top":
                    ws.get_Range(from, to).VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                    break;
                default:
                    break;
            }
        }
        public static void VytvorTabulku(Excel.Application excelApp)
        {
            //Excel._Worksheet workSheet = excelApp.Sheets.Add();
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.Sheets.Add();
            worksheet.Name = "Výkaz";



            //worksheet.Columns("A").ColumnWidth = 4;

            ((Excel.Range)worksheet.Columns[1]).ColumnWidth = 4;
            ((Excel.Range)worksheet.Columns[2]).ColumnWidth = 7;
            ((Excel.Range)worksheet.Columns[3]).ColumnWidth = 22.5;
            ((Excel.Range)worksheet.Columns[4]).ColumnWidth = 8;
            ((Excel.Range)worksheet.Columns[5]).ColumnWidth = 20;
            ((Excel.Range)worksheet.Columns[6]).ColumnWidth = 8.5;

            worksheet.Cells[1, "B"] = "Dětský donmov, Jablonec nad Nisou, Pasecká 20, příspěvková organizace";
            worksheet.Cells[3, "B"] = "Výkaz práce - služby:";
            worksheet.Cells[4, "B"] = "Za období:";
            worksheet.Cells[5, "B"] = "Jméno a příjmení: ";

            //worksheet.Cells[4, "E"] = "OBDOBÍ";

            worksheet.Range[worksheet.Cells[7, "B"], worksheet.Cells[8, "B"]].Merge();
            worksheet.Range[worksheet.Cells[7, "C"], worksheet.Cells[8, "C"]].Merge();
            worksheet.Range[worksheet.Cells[7, "D"], worksheet.Cells[8, "D"]].Merge();
            worksheet.Range[worksheet.Cells[7, "E"], worksheet.Cells[8, "E"]].Merge();
            worksheet.Range[worksheet.Cells[7, "F"], worksheet.Cells[8, "F"]].Merge();

            worksheet.Cells[7, "B"] = "Datum";
            worksheet.Cells[7, "C"] = "PPP" + (char)10 + "(od-do)";
            worksheet.Cells[7, "D"] = "PPP" + (char)10 + "(hodiny)";
            worksheet.Cells[7, "E"] = "NPČ" + (char)10 + "(hodiny)";
            worksheet.Cells[7, "F"] = "PPP+NPČ" + (char)10 + "celkem";
            //worksheet.Range.mer


            VertikalniZarovnani(worksheet, "B7", "B7", "center");
            VertikalniZarovnani(worksheet, "C7", "C7", "center");
            VertikalniZarovnani(worksheet, "D7", "D7", "center");
            VertikalniZarovnani(worksheet, "E7", "E7", "center");
            VertikalniZarovnani(worksheet, "F7", "F7", "center");

            HorizontalniZarovnani(worksheet, "B7", "B7", "center");
            HorizontalniZarovnani(worksheet, "C7", "C7", "center");
            HorizontalniZarovnani(worksheet, "D7", "D7", "center");
            HorizontalniZarovnani(worksheet, "E7", "E7", "center");
            HorizontalniZarovnani(worksheet, "F7", "F7", "center");




            //(Excel.Range)(worksheet.Range[worksheet.Cells[7, "B"], worksheet.Cells[8, "B"]].Cells).MergeCells();
            // ((Excel.Range)worksheet.Cells["B7", "B8"]).MergeCells(); 


            //worksheet.Cells[7, "G"] = "Datum";
            //worksheet.Cells[7, "B"] = "Datum";

        }
    }
}
