using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskForDTC.Model;
using TestTaskForDTC.Service;

namespace TestTaskForDTC.ViewModel
{

    public class CoinsCapViewModel
    {
        public ObservableCollection<CoinCapInfo> CoinInfo { get; set; }

        public CoinsCapViewModel()
        {
            LoadCoins();
        }

        private async void LoadCoins()
        {   
            CoinInfo = new ObservableCollection<CoinCapInfo>();
            List<CoinCapInfo> res = await Task.Run(async () =>
            {
                CoinCapClient client = new CoinCapClient();
                return await client.GetCoinCapList();
            });
            foreach (CoinCapInfo coinCap in res)
            {
                CoinInfo.Add(coinCap);
            }
        }

        public async void FillObservableListWithCoins(List<CoinCapInfo> list)
        {
            CoinInfo.Clear();
              foreach (CoinCapInfo coinCap in list)
            {
                CoinInfo.Add(coinCap);
            }
        }

    }
}
