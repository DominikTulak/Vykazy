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

namespace Vykazy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.MainWindowController Controller;
        public MainWindow()
        {
            InitializeComponent();
            Controller = new Controller.MainWindowController();
            Model.Convertors.VygenerovatMenu(cb_mesic, cb_rok);
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            Controller.BTNGenerateClick();
        }
        private void btn_Nastaveni_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
