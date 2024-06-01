using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManavBarkod
{
    public class UrunIslemleri
    {
        public static bool urunEkle(string urunad, List<Urun> list,DBManavEntities1 dbe,decimal totalKg,decimal totalP)
        {
            bool result = false;
            var b = from x in dbe.TBLUrunler where x.UrunAd == urunad select new { x.UrunAd, x.UrunFiyat };

            foreach (var c in b)
            {
                if (c.UrunAd == urunad )
                {
                    totalP = 0;
                    totalP = c.UrunFiyat * totalKg;
                    Urun urun = new Urun(c.UrunAd, c.UrunFiyat, totalKg, totalP);

                    list.Add(urun);
                    if (list.Count > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        MessageBox.Show("Stokları kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            return result;
        }
        public static void GetInfo(DataTable dataTable, List<Urun> list)
        {
            dataTable.Clear();
            foreach (var a in list)
            {
                DataRow dr = dataTable.NewRow();
                dr["Urun Adı"] = a.UrunAd;
                dr["Urun Fiyatı"] = a.UrunFiyat;
                dr["Urun Miktar"] = a.TopKg;
                dr["Tutar"] = a.TopFiyat;
                dataTable.Rows.Add(dr);
            }
        }
        public static bool CheckDB(DBManavEntities1 dbe,string ad,decimal miktar)
        {
            bool result = false;
            var query = from x in dbe.TBLUrunler where x.UrunAd == ad select new { x.UrunID,x.Stok };
            if (query.ToList().Count > 0)
            {
                decimal KG = query.ToList()[0].Stok - miktar;
                if (KG > 0)
                    result = true;
            }
                
            return result;
        }
    }
}
