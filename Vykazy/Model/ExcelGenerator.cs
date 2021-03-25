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
        public static void Ohraniceni(Excel._Worksheet ws, string from, string to, int weight)
        {
            ws.get_Range(from, to).BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            ws.get_Range(from, to).Borders.Weight = weight;
            ws.get_Range(from, to).Borders.Color = Excel.XlRgbColor.rgbBlack;
        }
        public static void VytvorTabulku(int Mesic, int Rok, string Jmeno, string Text1, string Text2, Excel.Application excelApp)
        {
            //Vytvoření tabulky
            Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.Sheets.Add();
            worksheet.Name = "Výkaz";


            //Nastaveni sirky sloupcu
            ((Excel.Range)worksheet.Columns[1]).ColumnWidth = 4;
            ((Excel.Range)worksheet.Columns[2]).ColumnWidth = 7;
            ((Excel.Range)worksheet.Columns[3]).ColumnWidth = 22.5;
            ((Excel.Range)worksheet.Columns[4]).ColumnWidth = 8;
            ((Excel.Range)worksheet.Columns[5]).ColumnWidth = 20;
            ((Excel.Range)worksheet.Columns[6]).ColumnWidth = 8.5;

            worksheet.Cells[1, "B"] = Text1;
            worksheet.Cells[3, "B"] = Text2;
            worksheet.Cells[4, "B"] = "Za období:";
            worksheet.Cells[5, "B"] = "Jméno a příjmení: ";

            //Spojeni policek
            worksheet.Range[worksheet.Cells[7, "B"], worksheet.Cells[8, "B"]].Merge();
            worksheet.Range[worksheet.Cells[7, "C"], worksheet.Cells[8, "C"]].Merge();
            worksheet.Range[worksheet.Cells[7, "D"], worksheet.Cells[8, "D"]].Merge();
            worksheet.Range[worksheet.Cells[7, "E"], worksheet.Cells[8, "E"]].Merge();
            worksheet.Range[worksheet.Cells[7, "F"], worksheet.Cells[8, "F"]].Merge();
            worksheet.get_Range("B1", "F1").Merge();

            worksheet.Cells[7, "B"] = "Datum";
            worksheet.Cells[7, "C"] = "PPP" + (char)10 + "(od-do)";
            worksheet.Cells[7, "D"] = "PPP" + (char)10 + "(hodiny)";
            worksheet.Cells[7, "E"] = "NPČ" + (char)10 + "(hodiny)";
            worksheet.Cells[7, "F"] = "PPP+NPČ" + (char)10 + "(celkem)";
            
            //Zarovnani policek
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
            HorizontalniZarovnani(worksheet, "B1", "F1", "center");

            worksheet.Cells[4, "E"] = Convertors.MesicSlovne(Mesic) + " " + Rok;
            worksheet.Cells[5, "E"] = Jmeno;

            //Ohraničení
            Ohraniceni(worksheet, "B7", "F8", 2);

            //Vygenerovani dnu
            int PocetDni = DateTime.DaysInMonth(Rok, Mesic);
            for (int i = 9; i < 9 + PocetDni; i++)
            {
                ((Excel.Range)worksheet.Cells[i, "B"]).NumberFormat = "@";
                worksheet.Cells[i, "B"] = (i - 8).ToString() + ".";
                HorizontalniZarovnani(worksheet, "B" + i.ToString(), "B" + i.ToString(), "center");
                ((Excel.Range)worksheet.Cells[i, "C"]).NumberFormat = "@";
                ((Excel.Range)worksheet.Cells[i, "D"]).NumberFormat = "#";
                ((Excel.Range)worksheet.Cells[i, "E"]).NumberFormat = "#";
                ((Excel.Range)worksheet.Cells[i, "F"]).FormulaLocal = String.Format("=SUMA(D{0}:E{0})", i);
                Ohraniceni(worksheet, "B" + i.ToString(), "F" + i.ToString(), 2);

            }

            worksheet.Cells[9 + PocetDni, "B"] = "Celkem";
            worksheet.get_Range("B" + (PocetDni + 9).ToString(), "C" + (PocetDni + 9).ToString()).Merge();
            Ohraniceni(worksheet, "B" + (PocetDni + 9).ToString(), "F" + (PocetDni + 9).ToString(), 2);
            ((Excel.Range)worksheet.Cells[9 + PocetDni, "D"]).FormulaLocal = String.Format("=SUMA(D9:D{0})", PocetDni + 8);
            ((Excel.Range)worksheet.Cells[9 + PocetDni, "E"]).FormulaLocal = String.Format("=SUMA(E9:E{0})", PocetDni + 8);
            ((Excel.Range)worksheet.Cells[9 + PocetDni, "F"]).FormulaLocal = String.Format("=SUMA(F9:F{0})", PocetDni + 8);
            HorizontalniZarovnani(worksheet, "B" + (9 + PocetDni).ToString(), "F" + (9 + PocetDni).ToString(), "center");
            Ohraniceni(worksheet, "B7", "F8", 3);

            worksheet.Cells[12 + PocetDni, "B"] = "Dne:  .........................     .........................     .........................     .........................";
            worksheet.Cells[13 + PocetDni, "B"] = "                                           Vychovatel/ka             Schváleno                Kontrola";
            worksheet.get_Range("B" + (12 + PocetDni).ToString(), "F" + (12 + PocetDni).ToString()).Merge();
            worksheet.get_Range("B" + (13 + PocetDni).ToString(), "F" + (13 + PocetDni).ToString()).Merge();

            //Vyhledat a označit víkendy
            for (int i = 1; i < PocetDni; i++)
            {
                if(Convertors.Vikend(i, Mesic, Rok))
                {
                    worksheet.get_Range("B" + (i + 8).ToString(), "F" + (i + 8).ToString()).Interior.Color = Excel.XlRgbColor.rgbGreenYellow;
                }
            }
            //Vyhledat a označit svátky
            for (int i = 1; i < PocetDni; i++)
            {
                if (Convertors.Svatek(i, Mesic))
                {
                    worksheet.get_Range("B" + (i + 8).ToString(), "F" + (i + 8).ToString()).Interior.Color = Excel.XlRgbColor.rgbLightPink;
                }
            }



            //(Excel.Range)(worksheet.Range[worksheet.Cells[7, "B"], worksheet.Cells[8, "B"]].Cells).MergeCells();
            // ((Excel.Range)worksheet.Cells["B7", "B8"]).MergeCells(); 


            //worksheet.Cells[7, "G"] = "Datum";
            //worksheet.Cells[7, "B"] = "Datum";

        }
    }
}
