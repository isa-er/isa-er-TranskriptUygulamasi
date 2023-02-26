
namespace BİL203_Ödev2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconTranskript = new System.Windows.Forms.PictureBox();
            this.iconSil = new System.Windows.Forms.PictureBox();
            this.iconGuncelle = new System.Windows.Forms.PictureBox();
            this.iconEkle = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTranskript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(11, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGoster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGoster.Location = new System.Drawing.Point(198, 21);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(220, 53);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "DERSLERİ GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnGoster);
            this.groupBox1.Location = new System.Drawing.Point(1, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOT GÖSTERME EKRANI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.iconTranskript);
            this.groupBox2.Controls.Add(this.iconSil);
            this.groupBox2.Controls.Add(this.iconGuncelle);
            this.groupBox2.Controls.Add(this.iconEkle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnTranskript);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnEkleme);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(674, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 383);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YAPILACAK İŞLEMLER";
            // 
            // iconTranskript
            // 
            this.iconTranskript.Image = ((System.Drawing.Image)(resources.GetObject("iconTranskript.Image")));
            this.iconTranskript.Location = new System.Drawing.Point(10, 294);
            this.iconTranskript.Name = "iconTranskript";
            this.iconTranskript.Size = new System.Drawing.Size(52, 49);
            this.iconTranskript.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconTranskript.TabIndex = 8;
            this.iconTranskript.TabStop = false;
            // 
            // iconSil
            // 
            this.iconSil.Image = ((System.Drawing.Image)(resources.GetObject("iconSil.Image")));
            this.iconSil.Location = new System.Drawing.Point(6, 216);
            this.iconSil.Name = "iconSil";
            this.iconSil.Size = new System.Drawing.Size(52, 49);
            this.iconSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconSil.TabIndex = 7;
            this.iconSil.TabStop = false;
            // 
            // iconGuncelle
            // 
            this.iconGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("iconGuncelle.Image")));
            this.iconGuncelle.Location = new System.Drawing.Point(10, 125);
            this.iconGuncelle.Name = "iconGuncelle";
            this.iconGuncelle.Size = new System.Drawing.Size(52, 49);
            this.iconGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconGuncelle.TabIndex = 6;
            this.iconGuncelle.TabStop = false;
            // 
            // iconEkle
            // 
            this.iconEkle.Image = ((System.Drawing.Image)(resources.GetObject("iconEkle.Image")));
            this.iconEkle.Location = new System.Drawing.Point(6, 47);
            this.iconEkle.Name = "iconEkle";
            this.iconEkle.Size = new System.Drawing.Size(52, 50);
            this.iconEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconEkle.TabIndex = 5;
            this.iconEkle.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSil.Location = new System.Drawing.Point(72, 207);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(206, 72);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "DERS SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTranskript.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTranskript.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnTranskript.Location = new System.Drawing.Point(72, 285);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(206, 67);
            this.btnTranskript.TabIndex = 3;
            this.btnTranskript.Text = "TRANSKRİPT GÖRÜNTÜLE";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(72, 118);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(206, 66);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "DERS GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEkleme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleme.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEkleme.Location = new System.Drawing.Point(72, 37);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(206, 66);
            this.btnEkleme.TabIndex = 0;
            this.btnEkleme.Text = "DERS EKLE";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.ekleme_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCikis.Location = new System.Drawing.Point(754, 22);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(41, 17);
            this.lblCikis.TabIndex = 49;
            this.lblCikis.Text = "ÇIKIŞ";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(801, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 58);
            this.btnCikis.TabIndex = 48;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCikis);
            this.Name = "Form1";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTranskript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox iconTranskript;
        private System.Windows.Forms.PictureBox iconSil;
        private System.Windows.Forms.PictureBox iconGuncelle;
        private System.Windows.Forms.PictureBox iconEkle;
    }
}

