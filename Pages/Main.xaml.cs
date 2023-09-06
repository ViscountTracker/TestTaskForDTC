using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using TestTaskForDTC.Model;
using TestTaskForDTC.Service;
using TestTaskForDTC.View;
using TestTaskForDTC.ViewModel;

namespace TestTaskForDTC.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public static CoinsCapViewModel coinsInfomationViewModel;
        public  Main()
        {
            InitializeComponent();
        }

        private void CoinViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            coinsInfomationViewModel = new CoinsCapViewModel();
            CoinsInfomationView.DataContext = coinsInfomationViewModel;
        }

        private async void Button_Click_Find(object sender, RoutedEventArgs e)
        {
            var toSearch = SearchTextBox.Text;
            List<CoinCapInfo> result = await Task.Run(async () =>
            {
                CoinCapClient client = new CoinCapClient();
                return await client.GetCoinsByFilter(toSearch);
            });
            coinsInfomationViewModel.FillObservableListWithCoins(result);
        }
        
    }
}
