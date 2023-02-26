
namespace BİL203_Ödev2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAnaMenu = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDersiGoster = new System.Windows.Forms.Button();
            this.txtHangiDersKodu = new System.Windows.Forms.TextBox();
            this.btnDersiSil = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGuncellemeYonlendir = new System.Windows.Forms.Label();
            this.lblTranskriptYonlendir = new System.Windows.Forms.Label();
            this.btnTranskriptYonlendir = new System.Windows.Forms.Button();
            this.btnGuncellemeYonlendir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAnaMenu.Location = new System.Drawing.Point(12, 64);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(72, 17);
            this.lblAnaMenu.TabIndex = 50;
            this.lblAnaMenu.Text = "Ana Menü";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCikis.Location = new System.Drawing.Point(101, 64);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(37, 17);
            this.lblCikis.TabIndex = 49;
            this.lblCikis.Text = "Çıkış";
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(87, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 58);
            this.btnCikis.TabIndex = 48;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnaMenu.BackgroundImage")));
            this.btnAnaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnaMenu.Location = new System.Drawing.Point(12, 3);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(55, 58);
            this.btnAnaMenu.TabIndex = 47;
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDersiGoster);
            this.groupBox2.Controls.Add(this.txtHangiDersKodu);
            this.groupBox2.Controls.Add(this.btnDersiSil);
            this.groupBox2.Controls.Add(this.btnIptalEt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 338);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DERS LİSTELEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "DERS KODUNU GİR:";
            // 
            // btnDersiGoster
            // 
            this.btnDersiGoster.BackColor = System.Drawing.Color.HotPink;
            this.btnDersiGoster.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersiGoster.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDersiGoster.Location = new System.Drawing.Point(9, 129);
            this.btnDersiGoster.Name = "btnDersiGoster";
            this.btnDersiGoster.Size = new System.Drawing.Size(285, 72);
            this.btnDersiGoster.TabIndex = 17;
            this.btnDersiGoster.Text = "DERSİ GÖSTER";
            this.btnDersiGoster.UseVisualStyleBackColor = false;
            this.btnDersiGoster.Click += new System.EventHandler(this.btnDersiGoster_Click);
            // 
            // txtHangiDersKodu
            // 
            this.txtHangiDersKodu.Location = new System.Drawing.Point(191, 53);
            this.txtHangiDersKodu.Name = "txtHangiDersKodu";
            this.txtHangiDersKodu.Size = new System.Drawing.Size(103, 24);
            this.txtHangiDersKodu.TabIndex = 16;
            // 
            // btnDersiSil
            // 
            this.btnDersiSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDersiSil.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersiSil.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDersiSil.Location = new System.Drawing.Point(3, 247);
            this.btnDersiSil.Name = "btnDersiSil";
            this.btnDersiSil.Size = new System.Drawing.Size(147, 72);
            this.btnDersiSil.TabIndex = 35;
            this.btnDersiSil.Text = "DERSİ SİL";
            this.btnDersiSil.UseVisualStyleBackColor = false;
            this.btnDersiSil.Click += new System.EventHandler(this.btnDersiSil_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.BackColor = System.Drawing.Color.Tomato;
            this.btnIptalEt.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnIptalEt.Location = new System.Drawing.Point(156, 247);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(138, 72);
            this.btnIptalEt.TabIndex = 38;
            this.btnIptalEt.Text = "İPTAL";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(335, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 338);
            this.dataGridView1.TabIndex = 32;
            // 
            // lblGuncellemeYonlendir
            // 
            this.lblGuncellemeYonlendir.AutoSize = true;
            this.lblGuncellemeYonlendir.Location = new System.Drawing.Point(160, 46);
            this.lblGuncellemeYonlendir.Name = "lblGuncellemeYonlendir";
            this.lblGuncellemeYonlendir.Size = new System.Drawing.Size(121, 17);
            this.lblGuncellemeYonlendir.TabIndex = 55;
            this.lblGuncellemeYonlendir.Text = "Ders Güncelleme ";
            // 
            // lblTranskriptYonlendir
            // 
            this.lblTranskriptYonlendir.AutoSize = true;
            this.lblTranskriptYonlendir.Location = new System.Drawing.Point(351, 48);
            this.lblTranskriptYonlendir.Name = "lblTranskriptYonlendir";
            this.lblTranskriptYonlendir.Size = new System.Drawing.Size(72, 17);
            this.lblTranskriptYonlendir.TabIndex = 54;
            this.lblTranskriptYonlendir.Text = "Transkript";
            // 
            // btnTranskriptYonlendir
            // 
            this.btnTranskriptYonlendir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTranskriptYonlendir.BackgroundImage")));
            this.btnTranskriptYonlendir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTranskriptYonlendir.Location = new System.Drawing.Point(340, 10);
            this.btnTranskriptYonlendir.Name = "btnTranskriptYonlendir";
            this.btnTranskriptYonlendir.Size = new System.Drawing.Size(133, 33);
            this.btnTranskriptYonlendir.TabIndex = 53;
            this.btnTranskriptYonlendir.UseVisualStyleBackColor = true;
            this.btnTranskriptYonlendir.Click += new System.EventHandler(this.btnTranskriptYonlendir_Click);
            // 
            // btnGuncellemeYonlendir
            // 
            this.btnGuncellemeYonlendir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuncellemeYonlendir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncellemeYonlendir.BackgroundImage")));
            this.btnGuncellemeYonlendir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncellemeYonlendir.Location = new System.Drawing.Point(163, 12);
            this.btnGuncellemeYonlendir.Name = "btnGuncellemeYonlendir";
            this.btnGuncellemeYonlendir.Size = new System.Drawing.Size(143, 31);
            this.btnGuncellemeYonlendir.TabIndex = 52;
            this.btnGuncellemeYonlendir.UseVisualStyleBackColor = false;
            this.btnGuncellemeYonlendir.Click += new System.EventHandler(this.btnGuncellemeYonlendir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.lblGuncellemeYonlendir);
            this.Controls.Add(this.lblTranskriptYonlendir);
            this.Controls.Add(this.btnTranskriptYonlendir);
            this.Controls.Add(this.btnGuncellemeYonlendir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAnaMenu);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "Form4";
            this.Text = "DERS SİLME SAYFASI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnaMenu;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDersiGoster;
        private System.Windows.Forms.TextBox txtHangiDersKodu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDersiSil;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Label lblGuncellemeYonlendir;
        private System.Windows.Forms.Label lblTranskriptYonlendir;
        private System.Windows.Forms.Button btnTranskriptYonlendir;
        private System.Windows.Forms.Button btnGuncellemeYonlendir;
    }
}