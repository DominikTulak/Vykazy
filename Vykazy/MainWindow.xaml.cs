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
        Controller.MainWindowController controller = new Controller.MainWindowController();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNGenerate_Click(object sender, RoutedEventArgs e)
        {
            
            controller.BTNGenerateClick();
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var eapp = excelApp.Workbooks.Add();
            VytvorTabulku(excelApp);
            //VytvorTabulku("Švédská", excelApp);
            //eapp.Worksheets["List1"].Delete();

        }
        
    }
}
