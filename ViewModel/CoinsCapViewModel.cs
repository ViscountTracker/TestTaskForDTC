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
            CoinInfo = new ObservableCollection<CoinCapInfo>();

            LoadCoins();
        }

        public async void LoadCoins(int limit = 10)
        {   
             List<CoinCapInfo> res = await Task.Run(async () =>
            {
                CoinCapClient client = new CoinCapClient();
                return await client.GetCoinCapList(limit);
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
