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
        public void BTNGenerateClick()
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var eapp = excelApp.Workbooks.Add();
            Model.ExcelGenerator.VytvorTabulku(excelApp);

        }
    }
}
