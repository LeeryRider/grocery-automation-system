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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }
        DBManavEntities1 dbe = new DBManavEntities1();
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(YetkiliIslemleri.PassControl(maskedTextBox1.Text,dbe)== true )
            {
                if(YetkiliIslemleri.ChangePass(maskedTextBox2.Text, dbe) == true)
                    MessageBox.Show("Şifre başarıyla değiştirildi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Bir hata oluştu.");
            }
            else
                MessageBox.Show("Lütfen eski şifrenizi doğru giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
    }
}
