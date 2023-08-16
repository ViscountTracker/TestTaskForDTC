using Prism.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestTaskForDTC.Model;
using TestTaskForDTC.Service;

namespace TestTaskForDTC.ViewModel
{
    internal class DetailCoinInfoViewModel
    {
        public DetailCoinInfoModel DetailCoinInfo{ get; set; }
        public string CoinId;

        public DetailCoinInfoViewModel(string coinId)
        {
            CoinId = coinId;
            LoadDetailCoins();
        }
        public async void LoadDetailCoins() 
        {
            DetailCoinInfo = new DetailCoinInfoModel();
            var localDetailCoinInfo = await Task.Run(async () =>
            {
                CoinCapClient client = new CoinCapClient();
                return await client.GetDetailCoin(CoinId);
            });
            DetailCoinInfo.Id = localDetailCoinInfo?.Id;
            DetailCoinInfo.Name= localDetailCoinInfo?.Name; 
            DetailCoinInfo.Symbol = localDetailCoinInfo?.Symbol;
            DetailCoinInfo.Rank = localDetailCoinInfo?.Rank;
            DetailCoinInfo.PriceUsd = localDetailCoinInfo?.PriceUsd;
            DetailCoinInfo.Supply = localDetailCoinInfo?.Supply;
            DetailCoinInfo.MarketCapUsd = localDetailCoinInfo?.MarketCapUsd;
            DetailCoinInfo.VolumeUsd24Hr = localDetailCoinInfo?.VolumeUsd24Hr;
        }
    }

}

