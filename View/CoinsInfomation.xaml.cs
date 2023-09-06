using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata;
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
using TestTaskForDTC.Pages;
using static System.Net.WebRequestMethods;


namespace TestTaskForDTC.View
{
    /// <summary>
    /// Interaction logic for CoinsInfomation.xaml
    /// </summary>
    public partial class CoinsInfomation : UserControl
    {
        private object moreInfoStackPanel;

        public CoinsInfomation()
        {
            InitializeComponent();
        }
        private void SwitchToDetailCoin(object sender, MouseButtonEventArgs e)
        {
             Switcher.Switch(new CoinInformationPage(((StackPanel)sender).Tag.ToString()));
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {//TODO: Fix logic error in this path of code 
            ComboBox cmb = sender as ComboBox;
            int cmbLimit = Int16.Parse(cmb.SelectedItem.ToString());
            Main.coinsInfomationViewModel.LoadCoins(cmbLimit);
            MessageBox.Show($"{cmbLimit}");
        }
    }
}
