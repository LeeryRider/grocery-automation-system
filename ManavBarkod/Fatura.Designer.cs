namespace ManavBarkod
{
    partial class Fatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFaturaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetFatura = new System.Windows.Forms.Button();
            this.btnFaturaGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.txtFaturaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFaturaID.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFaturaID.Location = new System.Drawing.Point(98, 628);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(186, 16);
            this.txtFaturaID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fatura ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(14, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 1);
            this.panel1.TabIndex = 29;
            // 
            // btnGetFatura
            // 
            this.btnGetFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFatura.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetFatura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetFatura.Location = new System.Drawing.Point(303, 623);
            this.btnGetFatura.Name = "btnGetFatura";
            this.btnGetFatura.Size = new System.Drawing.Size(129, 25);
            this.btnGetFatura.TabIndex = 28;
            this.btnGetFatura.Text = "Görüntüle";
            this.btnGetFatura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetFatura.UseVisualStyleBackColor = true;
            // 
            // btnFaturaGoruntule
            // 
            this.btnFaturaGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaGoruntule.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaGoruntule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFaturaGoruntule.Location = new System.Drawing.Point(489, 619);
            this.btnFaturaGoruntule.Name = "btnFaturaGoruntule";
            this.btnFaturaGoruntule.Size = new System.Drawing.Size(183, 36);
            this.btnFaturaGoruntule.TabIndex = 30;
            this.btnFaturaGoruntule.Text = "Tüm Faturaları Görüntüle";
            this.btnFaturaGoruntule.UseVisualStyleBackColor = true;
            this.btnFaturaGoruntule.Click += new System.EventHandler(this.btnFaturaGoruntule_Click);
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(684, 679);
            this.Controls.Add(this.btnFaturaGoruntule);
            this.Controls.Add(this.txtFaturaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetFatura);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fatura";
            this.Text = "Fatura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFaturaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetFatura;
        private System.Windows.Forms.Button btnFaturaGoruntule;
    }
}