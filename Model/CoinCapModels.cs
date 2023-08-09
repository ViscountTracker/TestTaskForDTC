using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace TestTaskForDTC.Model
{
    public class CoinsCapInfoResponse
    {
        public List<CoinCapInfo> data { get; set; }

    }
    public class CoinCapInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Rank { get; set; }
        public string PriceUsd { get; set; }

        public CoinCapInfo(string id, string name, string symbol, string rank, string priceUsd)
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            Rank = rank;
            PriceUsd = float.Parse(priceUsd).ToString("0.0000");
        }
    
    }
}
