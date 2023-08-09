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
using TestTaskForDTC.View;
using TestTaskForDTC.ViewModel;

namespace TestTaskForDTC.Pages
{
    /// <summary>
    /// Interaction logic for CoinInformationPage.xaml
    /// </summary>
    
   
    public partial class CoinInformationPage : UserControl
    {
        public string CoinId { get; set; }

        public CoinInformationPage(string coinId)
        {
            InitializeComponent();
            CoinId = coinId;    
        }

        private void DetailsCoinInfoView_Loaded(object sender, RoutedEventArgs e)
        {
            DetailCoinInfoViewModel coinsInfomationViewModel = new DetailCoinInfoViewModel(CoinId);
            DetailsCoinInfoView.DataContext = coinsInfomationViewModel.DetailCoinInfo;
        }
    }
}
