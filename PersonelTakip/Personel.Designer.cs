namespace PersonelTakip
{
    partial class Personel
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrsPzs = new System.Windows.Forms.ComboBox();
            this.pozisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
           
            this.txtPrsDpt = new System.Windows.Forms.ComboBox();
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrsUser = new System.Windows.Forms.TextBox();
            this.txtPrsSoyad = new System.Windows.Forms.TextBox();
            this.txtPrsAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
      
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonBindingSource)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtPrsPzs);
            this.panel1.Controls.Add(this.txtPrsDpt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrsUser);
            this.panel1.Controls.Add(this.txtPrsSoyad);
            this.panel1.Controls.Add(this.txtPrsAd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 125);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(557, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(557, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPrsPzs
            // 
            this.txtPrsPzs.FormattingEnabled = true;
            this.txtPrsPzs.Location = new System.Drawing.Point(384, 66);
            this.txtPrsPzs.Name = "txtPrsPzs";
            this.txtPrsPzs.Size = new System.Drawing.Size(121, 21);
            this.txtPrsPzs.TabIndex = 23;
            // 
            // pozisyonBindingSource
            // 
            this.pozisyonBindingSource.DataMember = "Pozisyon";
           
            // 
            // dataSet1
            // 
          
            // 
            // txtPrsDpt
            // 
            this.txtPrsDpt.FormattingEnabled = true;
            this.txtPrsDpt.Location = new System.Drawing.Point(384, 15);
            this.txtPrsDpt.Name = "txtPrsDpt";
            this.txtPrsDpt.Size = new System.Drawing.Size(121, 21);
            this.txtPrsDpt.TabIndex = 22;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
          
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(272, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pozisyon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(272, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Departman";
            // 
            // txtPrsUser
            // 
            this.txtPrsUser.Location = new System.Drawing.Point(127, 14);
            this.txtPrsUser.Name = "txtPrsUser";
            this.txtPrsUser.Size = new System.Drawing.Size(100, 20);
            this.txtPrsUser.TabIndex = 19;
            // 
            // txtPrsSoyad
            // 
            this.txtPrsSoyad.Location = new System.Drawing.Point(127, 99);
            this.txtPrsSoyad.Name = "txtPrsSoyad";
            this.txtPrsSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPrsSoyad.TabIndex = 18;
            // 
            // txtPrsAd
            // 
            this.txtPrsAd.Location = new System.Drawing.Point(127, 51);
            this.txtPrsAd.Name = "txtPrsAd";
            this.txtPrsAd.Size = new System.Drawing.Size(100, 20);
            this.txtPrsAd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "User No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(-1, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 129);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(496, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 48);
            this.button4.TabIndex = 18;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(348, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 48);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(196, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 48);
            this.button5.TabIndex = 16;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(50, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 48);
            this.button6.TabIndex = 15;
            this.button6.Text = "Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            
            // 
            // personelTableAdapter
            // 
          
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // departmanTableAdapter
            // 
          
            // 
            // pozisyonTableAdapter
            // 
           
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pozisyonBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrsUser;
        private System.Windows.Forms.TextBox txtPrsSoyad;
        private System.Windows.Forms.TextBox txtPrsAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtPrsPzs;
        private System.Windows.Forms.ComboBox txtPrsDpt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
       
        private System.Windows.Forms.BindingSource personelBindingSource;
       
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource departmanBindingSource;
      
        private System.Windows.Forms.BindingSource pozisyonBindingSource;
      
    }
}