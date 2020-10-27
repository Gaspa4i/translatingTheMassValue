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

namespace translatingTheMassValue
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtMassa.Text = "";
            rBFunt.IsChecked = false;
            rBPud.IsChecked = false;
            rBUnc.IsChecked = false;
            rBDrahma.IsChecked = false;
            rBGran.IsChecked = false;
            txtMassaResult.Text = "";
        }

        private void rBFunt_Checked(object sender, RoutedEventArgs e)
        {
            double massa = Convert.ToDouble(txtMassa.Text);
            massa = massa / 454;
            txtMassaResult.Text = massa.ToString();
        }

        private void rBPud_Checked(object sender, RoutedEventArgs e)
        {
            double massa = Convert.ToDouble(txtMassa.Text);
            massa = massa / 16380;
            txtMassaResult.Text = massa.ToString();
        }

        private void rBUnc_Checked(object sender, RoutedEventArgs e)
        {
            double massa = Convert.ToDouble(txtMassa.Text);
            massa = massa / 28.35;
            txtMassaResult.Text = massa.ToString();
        }

        private void rBDrahma_Checked(object sender, RoutedEventArgs e)
        {
            double massa = Convert.ToDouble(txtMassa.Text);
            massa = massa / 1.772;
            txtMassaResult.Text = massa.ToString();
        }

        private void rBGran_Checked(object sender, RoutedEventArgs e)
        {
            double massa = Convert.ToDouble(txtMassa.Text);
            massa = massa / 0.0648;
            txtMassaResult.Text = massa.ToString();
        }
    }
}
