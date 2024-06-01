using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManavBarkod
{
    public partial class Form1 : Form
    {
        #region Fields
        int i = 0;
        string secili;
        DataTable dataTable = new DataTable();
        decimal totalP = 0;
        decimal toplamTutar = 0;
        decimal totalKg = 0;
        DBManavEntities1 dbe = new DBManavEntities1();
        public List<Urun> total = new List<Urun>();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        

        
        #region PictureBox Animasyon

        private void pictureBoxDomates_MouseEnter(object sender, EventArgs e)
        {
            panelDom.BackColor = Color.DodgerBlue;
            pictureBoxDomates.Width = 115;
            pictureBoxDomates.Height = 86;
        }
        private void pictureBoxDomates_MouseLeave(object sender, EventArgs e)
        {
            panelDom.BackColor = Color.White;
            pictureBoxDomates.Width = 108;
            pictureBoxDomates.Height = 79;
        }
        private void pictureBoxLimon_MouseEnter(object sender, EventArgs e)
        {
            panelLim.BackColor = Color.DodgerBlue;
            pictureBoxLimon.Width = 115;
            pictureBoxLimon.Height = 86;
        }
        private void pictureBoxLimon_MouseLeave(object sender, EventArgs e)
        {
            panelLim.BackColor = Color.White;
            pictureBoxLimon.Width = 108;
            pictureBoxLimon.Height = 79;
        }
        private void pictureBoxSalatalık_MouseEnter(object sender, EventArgs e)
        {
            panelSal.BackColor = Color.DodgerBlue;
            pictureBoxSalatalık.Width = 115;
            pictureBoxSalatalık.Height = 86;
        }

        private void pictureBoxSalatalık_MouseLeave(object sender, EventArgs e)
        {
            panelSal.BackColor = Color.White;
            pictureBoxSalatalık.Width = 108;
            pictureBoxSalatalık.Height = 79;
        }

        private void pictureBoxIspanak_MouseEnter(object sender, EventArgs e)
        {
            panelIs.BackColor = Color.DodgerBlue;
            pictureBoxIspanak.Width = 115;
            pictureBoxIspanak.Height = 86;
        }

        private void pictureBoxIspanak_MouseLeave(object sender, EventArgs e)
        {
            panelIs.BackColor = Color.White;
            pictureBoxIspanak.Width = 108;
            pictureBoxIspanak.Height = 79;
        }
        private void pictureBoxPatlican_MouseEnter(object sender, EventArgs e)
        {
            panelPat.BackColor = Color.DodgerBlue;
            pictureBoxPatlican.Width = 115;
            pictureBoxPatlican.Height = 86;
        }

        private void pictureBoxPatlican_MouseLeave(object sender, EventArgs e)
        {
            panelPat.BackColor = Color.White;
            pictureBoxPatlican.Width = 108;
            pictureBoxPatlican.Height = 79;
        }

        private void pictureBoxMarul_MouseEnter(object sender, EventArgs e)
        {
            panelMar.BackColor = Color.DodgerBlue;
            pictureBoxMarul.Width = 115;
            pictureBoxMarul.Height = 86;
        }

        private void pictureBoxMarul_MouseLeave(object sender, EventArgs e)
        {
            panelMar.BackColor = Color.White;
            pictureBoxMarul.Width = 108;
            pictureBoxMarul.Height = 79;
        }

        private void pictureBoxHavuc_MouseEnter(object sender, EventArgs e)
        {
            panelHav.BackColor = Color.DodgerBlue;
            pictureBoxHavuc.Width = 115;
            pictureBoxHavuc.Height = 86;
        }

        private void pictureBoxHavuc_MouseLeave(object sender, EventArgs e)
        {
            panelHav.BackColor = Color.White;
            pictureBoxHavuc.Width = 108;
            pictureBoxHavuc.Height = 79;
        }

        private void pictureBoxYesilSogan_MouseEnter(object sender, EventArgs e)
        {
            panelYeS.BackColor = Color.DodgerBlue;
            pictureBoxYesilSogan.Width = 115;
            pictureBoxYesilSogan.Height = 86;
        }

        private void pictureBoxYesilSogan_MouseLeave(object sender, EventArgs e)
        {
            panelYeS.BackColor = Color.White;
            pictureBoxYesilSogan.Width = 108;
            pictureBoxYesilSogan.Height = 79;
        }

        private void pictureBoxBrokoli_MouseEnter(object sender, EventArgs e)
        {
            panelBrok.BackColor = Color.DodgerBlue;
            pictureBoxBrokoli.Width = 115;
            pictureBoxBrokoli.Height = 86;
        }

        private void pictureBoxBrokoli_MouseLeave(object sender, EventArgs e)
        {
            panelBrok.BackColor = Color.White;
            pictureBoxBrokoli.Width = 108;
            pictureBoxBrokoli.Height = 79;
        }

        private void pictureBoxSogan_MouseEnter(object sender, EventArgs e)
        {
            panelSog.BackColor = Color.DodgerBlue;
            pictureBoxSogan.Width = 115;
            pictureBoxSogan.Height = 86;
        }

        private void pictureBoxSogan_MouseLeave(object sender, EventArgs e)
        {
            panelSog.BackColor = Color.White;
            pictureBoxSogan.Width = 108;
            pictureBoxSogan.Height = 79;
        }

        private void pictureBoxMaydanoz_MouseEnter(object sender, EventArgs e)
        {
            panelMay.BackColor = Color.DodgerBlue;
            pictureBoxMaydanoz.Width = 115;
            pictureBoxMaydanoz.Height = 86;
        }

        private void pictureBoxMaydanoz_MouseLeave(object sender, EventArgs e)
        {
            panelMay.BackColor = Color.White;
            pictureBoxMaydanoz.Width = 108;
            pictureBoxMaydanoz.Height = 79;
        }


        private void pictureBoxPortakal_MouseEnter(object sender, EventArgs e)
        {
            panelPor.BackColor = Color.DodgerBlue;
            pictureBoxPortakal.Width = 115;
            pictureBoxPortakal.Height = 86;
        }

        private void pictureBoxPortakal_MouseLeave(object sender, EventArgs e)
        {
            panelPor.BackColor = Color.White;
            pictureBoxPortakal.Width = 108;
            pictureBoxPortakal.Height = 79;
        }

        private void pictureBoxMuz_MouseEnter(object sender, EventArgs e)
        {
            panelMu.BackColor = Color.DodgerBlue;
            pictureBoxMuz.Width = 115;
            pictureBoxMuz.Height = 86;
        }

        private void pictureBoxMuz_MouseLeave(object sender, EventArgs e)
        {
            panelMu.BackColor = Color.White;
            pictureBoxMuz.Width = 108;
            pictureBoxMuz.Height = 79;
        }

        private void pictureBoxElma_MouseEnter(object sender, EventArgs e)
        {
            panelEl.BackColor = Color.DodgerBlue;
            pictureBoxElma.Width = 115;
            pictureBoxElma.Height = 86;
        }

        private void pictureBoxElma_MouseLeave(object sender, EventArgs e)
        {
            panelEl.BackColor = Color.White;
            pictureBoxElma.Width = 108;
            pictureBoxElma.Height = 79;
        }

        private void pictureBoxSeftali_MouseEnter(object sender, EventArgs e)
        {
            panelSef.BackColor = Color.DodgerBlue;
            pictureBoxSeftali.Width = 115;
            pictureBoxSeftali.Height = 86;
        }

        private void pictureBoxSeftali_MouseLeave(object sender, EventArgs e)
        {
            panelSef.BackColor = Color.White;
            pictureBoxSeftali.Width = 108;
            pictureBoxSeftali.Height = 79;
        }

        private void pictureBoxCilek_MouseEnter(object sender, EventArgs e)
        {
            panelCil.BackColor = Color.DodgerBlue;
            pictureBoxCilek.Width = 115;
            pictureBoxCilek.Height = 86;
        }

        private void pictureBoxCilek_MouseLeave(object sender, EventArgs e)
        {
            panelCil.BackColor = Color.White;
            pictureBoxCilek.Width = 108;
            pictureBoxCilek.Height = 79;
        }

        private void pictureBoxArmut_MouseEnter(object sender, EventArgs e)
        {
            panelArm.BackColor = Color.DodgerBlue;
            pictureBoxArmut.Width = 115;
            pictureBoxArmut.Height = 86;
        }

        private void pictureBoxArmut_MouseLeave(object sender, EventArgs e)
        {
            panelArm.BackColor = Color.White;
            pictureBoxArmut.Width = 108;
            pictureBoxArmut.Height = 79;
        }

        private void pictureBoxKarpuz_MouseEnter(object sender, EventArgs e)
        {
            panelKar.BackColor = Color.DodgerBlue;
            pictureBoxKarpuz.Width = 115;
            pictureBoxKarpuz.Height = 86;
        }

        private void pictureBoxKarpuz_MouseLeave(object sender, EventArgs e)
        {
            panelKar.BackColor = Color.White;
            pictureBoxKarpuz.Width = 108;
            pictureBoxKarpuz.Height = 79;
        }

        private void pictureBoxVisne_MouseEnter(object sender, EventArgs e)
        {
            panelKir.BackColor = Color.DodgerBlue;
            pictureBoxVisne.Width = 115;
            pictureBoxVisne.Height = 86;
        }

        private void pictureBoxVisne_MouseLeave(object sender, EventArgs e)
        {
            panelKir.BackColor = Color.White;
            pictureBoxVisne.Width = 108;
            pictureBoxVisne.Height = 79;
        }
        #endregion
        #region PictureBox Click
        private void pictureBoxDomates_Click(object sender, EventArgs e)
        {
            
            if (UrunIslemleri.CheckDB(dbe,"Domates", totalKg))
            {
                secili = "domates";
                string urun = "Domates";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        
        private void pictureBoxLimon_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Limon", totalKg))
            {
                secili = "limon";
                string urun = "Limon";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxSalatalık_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Salatalık", totalKg))
            {
                secili = "salatalık";
                string urun = "Salatalık";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxIspanak_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Ispanak", totalKg))
            {
                secili = "Ispanak";
                string urun = "Ispanak";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxPatlican_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Patlican", totalKg))
            {
                secili = "Patlican";
                string urun = "Patlican";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxMarul_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Marul", totalKg))
            {
                secili = "Marul";
                string urun = "Marul";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxHavuc_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Havuc", totalKg))
            {
                secili = "Havuc";
                string urun = "Havuc";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxYesilSogan_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "YesilSogan", totalKg))
            {
                secili = "YesilSogan";
                string urun = "YesilSogan";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxBrokoli_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Brokoli", totalKg) == true)
            {
                secili = "Brokoli";
                string urun = "Brokoli";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        private void pictureBoxSogan_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Sogan", totalKg))
            {
                secili = "Sogan";
                string urun = "Sogan";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void pictureBoxMaydanoz_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Maydanoz", totalKg))
            {
                secili = "Maydanoz";
                string urun = "Maydanoz";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        private void pictureBoxPortakal_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Portakal", totalKg))
            {
                secili = "Portakal";
                string urun = "Portakal";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxMuz_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Muz", totalKg))
            {
                secili = "Muz";
                string urun = "Muz";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxElma_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Elma", totalKg))
            {
                secili = "Elma";
                string urun = "Elma";               
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxSeftali_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Seftali", totalKg))
            {
                secili = "Seftali";
                string urun = "Seftali";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxCilek_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Cilek", totalKg))
            {
                secili = "Cilek";
                string urun = "Cilek";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxArmut_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Armut", totalKg))
            {
                secili = "Armut";
                string urun = "Armut";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxKarpuz_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Karpuz", totalKg))
            {
                secili = "Karpuz";
                string urun = "Karpuz";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void pictureBoxVisne_Click(object sender, EventArgs e)
        {
            if (UrunIslemleri.CheckDB(dbe, "Visne", totalKg))
            {
                secili = "Visne";
                string urun = "Visne";
                if (textBox1.Text != "")
                {
                    totalKg = Convert.ToDecimal(textBox1.Text);
                    UrunIslemleri.urunEkle(urun, total, dbe, totalKg, totalP);
                }
            }
            else
                MessageBox.Show("Ürün sistemde mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        #endregion
        #region Event
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnYetkili_Click(object sender, EventArgs e)
        {
            FormUpdate fu = new FormUpdate();
            fu.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[0].HeaderText = "Urun Adı";
            //dataGridView1.Columns[1].HeaderText = "Urun Fiyat";
            //dataGridView1.Columns[2].HeaderText = "Urun Miktar";
            //dataGridView1.Columns[3].HeaderText = "Tutar";
            dataTable.Columns.Add("Urun Adı");
            dataTable.Columns.Add("Urun Fiyatı");
            dataTable.Columns.Add("Urun Miktar");
            dataTable.Columns.Add("Tutar");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(total.Count > 0)
            {
                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex);
                toplamTutar -= total[i].TopFiyat;
                total.RemoveAt(i);
                lblTutar.Text = toplamTutar.ToString();
                UrunIslemleri.GetInfo(dataTable, total);
                dataGridView1.DataSource = dataTable;
            }
            else
                MessageBox.Show("Sepet zaten boş!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                foreach (var item in total)
                {
                    UrunIslemleri.GetInfo(dataTable, total);
                }
                if(total.Count > 0)
                {
                    toplamTutar += total.Last().TopFiyat;
                    lblTutar.Text = toplamTutar.ToString();
                }
            }
            else
                MessageBox.Show("Geçerli bir miktar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].HeaderText = "Urun Adı";
            dataGridView1.Columns[1].HeaderText = "Urun Fiyat";
            dataGridView1.Columns[2].HeaderText = "Urun Miktar";
            dataGridView1.Columns[3].HeaderText = "Tutar";
        }

        void Temizle(DataTable dt)
        {
            for (int i = 0; i < total.Count; i++)
            {
                toplamTutar -= total[i].TopFiyat;
            }
            total.Clear();
            dt.Clear();
            lblTutar.Text = toplamTutar.ToString();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if(total.Count >0 )
                Temizle(dataTable);
            else
                MessageBox.Show("Sepet zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buton ve TextBox Renklendirme
        private void btnEkle_MouseEnter(object sender, EventArgs e)
        {
            btnEkle.ForeColor = Color.DodgerBlue;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.ForeColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DodgerBlue;
            panelText.BackColor = Color.DodgerBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label2.ForeColor= Color.White;
            panelText.BackColor = Color.White;

        }
        #endregion

        
    }
}
