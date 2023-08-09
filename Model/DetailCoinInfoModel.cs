using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskForDTC.Model
{
    public class DetailCoinInfoModelResponse
    {
        public DetailCoinInfoModel data { get; set;}

    }
    public class DetailCoinInfoModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;

        private string id;
        private string name;
        private string symbol;
        private string rank;
        private string priceUsd;
        private string supply;
        private string marketCapUsd;
        private string volumeUsd24Hr;
        public string Id 
        {
            get 
            {
                return this.id;
            }
            set 
            {
                this.id = value;
                NotifyPropertyChanged();
            }
        }
        public string Name {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                NotifyPropertyChanged();
            }
        }
        public string Symbol {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol= value;
                NotifyPropertyChanged();
            }
        }
        public string Rank {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
                NotifyPropertyChanged();
            }
        }
        public string PriceUsd {
            get
            {
                return this.priceUsd;
            }
            set
            {
                this.priceUsd = value;
                NotifyPropertyChanged();
            }
        }
        public string Supply {
            get
            {
                return this.supply;
            }
            set
            {
                this.supply = value;
                NotifyPropertyChanged();
            }
        }
        public string MarketCapUsd {
            get
            {
                return this.marketCapUsd;
            }
            set
            {
                this.marketCapUsd = value;
                NotifyPropertyChanged();
            }
        }
        public string VolumeUsd24Hr {
            get
            {
                return this.volumeUsd24Hr;
            }
            set
            {
                this.volumeUsd24Hr = value;
                NotifyPropertyChanged();
            }
        }
        

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
         {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }

        public DetailCoinInfoModel()
        {
           
        }
        public DetailCoinInfoModel(string id, string name, string symbol, string rank, string priceUsd ,string supply, string marketCapUsd, string volumeUsd24Hr) 
        {
            Id = id;
            Name = name;
            Symbol = symbol;
            Rank = rank; 
            PriceUsd = priceUsd;
            Supply = supply;
            MarketCapUsd = marketCapUsd;
            VolumeUsd24Hr = volumeUsd24Hr;
        }

       
    }
}
