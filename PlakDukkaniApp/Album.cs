using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniApp
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string SanatciAdi { get; set; }
        public string SanatciSoyadi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal? IndirimOrani  { get; set; }

        public decimal IndirimliFiyat
        {
            get
            {

                if (IndirimOrani.HasValue)
                {
                    return Fiyat * (1 - IndirimOrani.Value / 100);
                }
                return Fiyat;
            }
            set { Fiyat = value; }
        }
        public SatisDurumu SatisiDevamEdiyorMu { get; set; }
        
    }
}
