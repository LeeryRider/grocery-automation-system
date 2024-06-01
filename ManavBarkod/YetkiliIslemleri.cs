using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManavBarkod
{
    public class YetkiliIslemleri
    {
        #region Password
        public static bool ChangePass(string pass,DBManavEntities1 dbe)
        {
            bool result = false;

            var query = dbe.TBLPassword.Find(0);
            if (query != null)
            {
                query.Password = pass;
                dbe.SaveChanges();
                result = true;
            }

            return result;
        }
        public static bool PassControl(string pass,DBManavEntities1 dbe)
        {
            bool result = false;
            var query = dbe.TBLPassword.Find(0);
            if(query.Password == pass)
            {
                result = true;
            }


            return result;
        }
        #endregion

        #region Urun İşlemleri
        public static bool UrunGuncelle(DBManavEntities1 dbe,string urunad,decimal satisFiyat,decimal alisFiyat,decimal stok,string tur)
        {
            bool result = false;
            if(urunad.Length > 0 && urunad.Length < 25)
            {
                var query = from x in dbe.TBLUrunler where x.UrunAd == urunad select x.UrunID;
                int id = query.First();
                var find = dbe.TBLUrunler.Find(id);
                find.UrunAd=urunad;
                find.UrunFiyat=satisFiyat;
                find.Stok=stok;
                find.Tur=tur;
                find.Maliyet = alisFiyat;
                dbe.SaveChanges();
                result = true;
            }  
            return result;
        }
        public static void UrunListele(DataGridView dv,DBManavEntities1 dbe)
        {
            var query = dbe.TBLUrunler.ToList();
            dv.DataSource = query;
        }
        public static bool UrunEkle(DBManavEntities1 dbe,TBLUrunler urun,string urunad)
        {
            bool result = false;
            var query = from x in dbe.TBLUrunler where x.UrunAd == urunad select x.UrunID;
            if (query.ToList().Count <= 0)
            {
                dbe.TBLUrunler.Add(urun);
                int i = dbe.SaveChanges();
                if (i > 0)
                {
                    result = true;
                }
            }
            else if(query.ToList().Count > 0)
                result = false;
            
            return result;
        }
        #endregion

    }
}
