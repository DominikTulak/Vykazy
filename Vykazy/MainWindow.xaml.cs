using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Vykazy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNGenerate_Click(object sender, RoutedEventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var eapp = excelApp.Workbooks.Add();
            VytvorTabulku(excelApp);
            //VytvorTabulku("Švédská", excelApp);
            //eapp.Worksheets["List1"].Delete();

        }
        private void VytvorTabulku(Excel.Application excelApp)
        {
            //Excel._Worksheet workSheet = excelApp.Sheets.Add();
            Excel._Worksheet worksheet = (Excel._Worksheet) excelApp.Sheets.Add();
            worksheet.Name = "Výkaz";

            worksheet.Cells[1, "B"] = "Dětský donmov, Jablonec nad Nisou, Pasecká 20, příspěvková organizace";
            worksheet.Cells[3, "B"] = "Výkaz práce - služby:";
            worksheet.Cells[4, "B"] = "Za období:";
            worksheet.Cells[5, "B"] = "Jméno a příjmení: ";

            //worksheet.Cells[4, "E"] = "OBDOBÍ";


        }
    }
}
