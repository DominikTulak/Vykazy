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
            Model.Settings.Nacist();
        }

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(cb_mesic.SelectedIndex+1 + "   " + int.Parse(cb_rok.SelectedItem.ToString()));
            Controller.BTNGenerateClick(cb_mesic.SelectedIndex + 1, int.Parse(cb_rok.SelectedItem.ToString()));
        }
        private void btn_Nastaveni_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
