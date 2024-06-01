using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManavBarkod
{
    public class FaturaIslemleri
    {
        //DBManavEntities1 dbe = new DBManavEntities1();
        //List<TBLFaturaMeyve> meyveList = new List<TBLFaturaMeyve>();
        //List<TBLFaturaSebze> sebzeList = new List<TBLFaturaSebze>();
        bool Kaydet(List<TBLFaturaMeyve> meyve,List<TBLFaturaSebze> sebze, List<TBLFatura> fatura, DBManavEntities1 dbe,DataGridView dv)
        {
            bool result = false;
            var sebzeler = from x in dbe.TBLUrunler where x.Tur == "Sebze" select new { x.UrunAd, x.Stok, x.UrunFiyat,x.Tur };
            var meyveler = from x in dbe.TBLUrunler where x.Tur == "Meyve" select new { x.UrunAd, x.Stok, x.UrunFiyat,x.Tur };
            
            return result;
        }
    }
}
