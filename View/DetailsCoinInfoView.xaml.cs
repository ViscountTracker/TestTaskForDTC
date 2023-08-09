using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace TestTaskForDTC.View
{
    /// <summary>
    /// Interaction logic for DetailsCoinInfoView.xaml
    /// </summary>
    public partial class DetailsCoinInfoView : UserControl
    {
        public DetailsCoinInfoView()
        {
            InitializeComponent();
        }

        private void OpenMarketLink(object sender, RoutedEventArgs e)
        {
            var marketId = ((Button)sender).Tag.ToString();
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {  
                FileName = $"https://coincap.io/assets/{marketId}",
                UseShellExecute = true
            });
        }
    }
}
