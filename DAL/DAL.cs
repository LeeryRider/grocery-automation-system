using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL
{
    public class DAL
    {
        public DAL() { }
        static DBManavEntities dbe = new DBManavEntities();
        public static void GetAllInfo(DataGridView dgv)
        {
            var query = from x in dbe.TBLUrunler select new { x.UrunID, x.UrunAd, x.UrunFiyat, x.Tur , x.Stok, x.Maliyet };
            dgv.DataSource = query.ToList();
        }
    }
}
