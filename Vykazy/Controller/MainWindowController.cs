using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace Vykazy.Controller
{
    class MainWindowController
    {
        public void BTNGenerateClick(int mesic, int rok)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var eapp = excelApp.Workbooks.Add();
            Model.ExcelGenerator.VytvorTabulku(mesic, rok, Model.Settings.Jmeno, Model.Settings.Text1, Model.Settings.Text2, excelApp);

        }
    }
}
