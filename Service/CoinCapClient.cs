using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using TestTaskForDTC.Model;
using TestTaskForDTC.ViewModel;

namespace TestTaskForDTC.Service
{
    public class CoinCapClient
    {
        public async Task<List<CoinCapInfo>> GetCoinCapList(int limit = 10)
        {
            HttpClient httpClient = new HttpClient();

            var items = new CoinsCapInfoResponse(); 

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.coincap.io/v2/assets?limit={limit}");
            if (response.IsSuccessStatusCode)
            {
                
                items = JsonConvert.DeserializeObject<CoinsCapInfoResponse>(await response.Content.ReadAsStringAsync());
            }
            return items.data;
        }

        public async Task<DetailCoinInfoModel?> getDetailCoin(string CoinId)
        {
            DetailCoinInfoModelResponse? item = null;
            HttpClient httpClient = new HttpClient();
           
            HttpResponseMessage response = await httpClient.GetAsync($"https://api.coincap.io/v2/assets/{CoinId}");
            if (response.IsSuccessStatusCode)
            {
             
                item = JsonConvert.DeserializeObject<DetailCoinInfoModelResponse>(await response.Content.ReadAsStringAsync());
            }
            if (item != null)
            {
                return item.data;
            }
            return null;
        }

        public async Task<List<CoinCapInfo>> GetCoinsByFilter(string toFind)
        {
            HttpClient httpClient = new HttpClient();

            var items = new CoinsCapInfoResponse();

            HttpResponseMessage response = await httpClient.GetAsync($"https://api.coincap.io/v2/assets?search={toFind}");
            if (response.IsSuccessStatusCode)
            {

                items = JsonConvert.DeserializeObject<CoinsCapInfoResponse>(await response.Content.ReadAsStringAsync());
            }
            return items.data;
        }

    }
}
