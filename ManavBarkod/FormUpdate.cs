using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManavBarkod
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }
        DBManavEntities1 dbe = new DBManavEntities1();
        string urunad;
        decimal satisFiyat;
        decimal alisFiyat;
        decimal stok;
        string tur;
        #region Textbox
        private void txtAd_Click(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.DodgerBlue;

            label1.ForeColor = Color.DodgerBlue;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            panel1.BackColor = Color.DodgerBlue;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            
        }

        private void txtSatisFiyat_Click(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.DodgerBlue;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.DodgerBlue;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void txtAlisFiyat_Click(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.DodgerBlue;
            label4.ForeColor = Color.White;

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.DodgerBlue;
            panel4.BackColor = Color.White;
        }

        private void txtStok_Click(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.White;

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.DodgerBlue;

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.DodgerBlue;
        }
        #endregion
        private void FormUpdate_Load(object sender, EventArgs e)
        {
            YetkiliIslemleri.UrunListele(dataGridView1, dbe);
            //groupBox1.Enabled = false;
            //btnEkle.Enabled= false;
            //btnUpdate.Enabled=false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtAd.Text!="" && txtAlisFiyat.Text!="" && txtSatisFiyat.Text!="" && txtStok.Text!="")
            {
                if (txtAd.Text.Length < 25)
                {
                    if (radMeyve.Checked == true || radSebze.Checked == true)
                    {
                        TBLUrunler urun = new TBLUrunler();
                        urun.UrunAd = txtAd.Text;
                        urun.UrunFiyat = Convert.ToDecimal(txtSatisFiyat.Text);
                        urun.Maliyet = Convert.ToDecimal(txtAlisFiyat.Text);
                        urun.Stok = Convert.ToDecimal(txtStok.Text);
                        if (radMeyve.Checked == true)
                        {
                            urun.Tur = "Meyve";
                        }
                        if (radSebze.Checked == true)
                        {
                            urun.Tur = "Sebze";
                        }
                        bool result = YetkiliIslemleri.UrunEkle(dbe, urun,txtAd.Text.ToString());
                        if(result)
                        {
                            YetkiliIslemleri.UrunListele(dataGridView1, dbe);
                            MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Ürün eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        YetkiliIslemleri.UrunListele(dataGridView1, dbe);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen ürün türü seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün adı 25 karakterden büyük olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ürün bilgilerini doğru bir şekilde giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YetkiliIslemleri.UrunListele(dataGridView1, dbe);
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if(txtAd.Text != "" && txtAd.Text.Length < 25)
            {
                var query = from x in dbe.TBLUrunler where x.UrunAd == txtAd.Text select x;
                if(query.ToList().Count() > 0)
                {
                    foreach (var a in query)
                    {
                        if (a.Tur == "Sebze")
                        {
                            radSebze.Checked = true;
                            radMeyve.Checked = false;
                        }
                        if (a.Tur == "Meyve")
                        {
                            radSebze.Checked = false;
                            radMeyve.Checked = true;
                        }
                        txtAlisFiyat.Text = a.Maliyet.ToString();
                        txtSatisFiyat.Text = a.UrunFiyat.ToString();
                        txtStok.Text = a.Stok.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Aradığınız ürün bulunamadı lütfen doğru şekilde giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ürün adını doğru bir şekilde giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtAd.Text != "" && txtAlisFiyat.Text !="" && txtSatisFiyat.Text !="" && txtStok.Text != "")
            {
                if(txtAd.Text.Length < 25)
                {
                    if(radMeyve.Checked == true || radSebze.Checked == true)
                    {
                        urunad = txtAd.Text;
                        satisFiyat = Convert.ToDecimal(txtSatisFiyat.Text);
                        alisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                        stok = Convert.ToDecimal(txtStok.Text);
                        if (radMeyve.Checked)
                            tur = "Meyve";
                        if (radSebze.Checked)
                            tur = "Sebze";
                        bool result = YetkiliIslemleri.UrunGuncelle(dbe, urunad, satisFiyat, alisFiyat, stok, tur);
                        if (result)
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            YetkiliIslemleri.UrunListele(dataGridView1, dbe);
                        }
                        else
                            MessageBox.Show("Beklenmeyen bir hata oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Lütfen ürün türünü işaretleyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                }
                else
                    MessageBox.Show("Ürün adı 25 karakterden büyük olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Lütfen alanları bir şekilde giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordForm form = new PasswordForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(YetkiliIslemleri.PassControl(maskedTextBox1.Text,dbe) == true)
            {
                groupBox1.Enabled = true;
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
