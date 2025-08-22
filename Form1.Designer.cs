namespace FileAnalyzer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_txtanlyz = new System.Windows.Forms.Button();
            this.btn_wordupload = new System.Windows.Forms.Button();
            this.txt_textuniqnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_fileselector = new System.Windows.Forms.ComboBox();
            this.lst_txttext = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_clearform = new System.Windows.Forms.Button();
            this.prg1_uploadstatus = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtx_wordtext = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.prg2_uploadstatus = new System.Windows.Forms.ProgressBar();
            this.txt_worduniqnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_wordanlyz = new System.Windows.Forms.Button();
            this.txt_wordpuncnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_textpuncnumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_wordrepeats = new System.Windows.Forms.ListBox();
            this.lst_txtrepeats = new System.Windows.Forms.ListBox();
            this.btn_txtupload = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_txtanlyz
            // 
            this.btn_txtanlyz.Location = new System.Drawing.Point(204, 322);
            this.btn_txtanlyz.Name = "btn_txtanlyz";
            this.btn_txtanlyz.Size = new System.Drawing.Size(182, 23);
            this.btn_txtanlyz.TabIndex = 0;
            this.btn_txtanlyz.Text = "Analiz Et";
            this.btn_txtanlyz.UseVisualStyleBackColor = true;
            this.btn_txtanlyz.Click += new System.EventHandler(this.btn_txtanlyz_Click);
            // 
            // btn_wordupload
            // 
            this.btn_wordupload.Location = new System.Drawing.Point(558, 35);
            this.btn_wordupload.Name = "btn_wordupload";
            this.btn_wordupload.Size = new System.Drawing.Size(182, 23);
            this.btn_wordupload.TabIndex = 1;
            this.btn_wordupload.Text = "Word Dosyası Yükle";
            this.btn_wordupload.UseVisualStyleBackColor = true;
            this.btn_wordupload.Click += new System.EventHandler(this.btn_wordupload_Click);
            // 
            // txt_textuniqnumber
            // 
            this.txt_textuniqnumber.Location = new System.Drawing.Point(53, 323);
            this.txt_textuniqnumber.Name = "txt_textuniqnumber";
            this.txt_textuniqnumber.ReadOnly = true;
            this.txt_textuniqnumber.Size = new System.Drawing.Size(123, 22);
            this.txt_textuniqnumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Farklı Kelime Sayısı";
            // 
            // cmb_fileselector
            // 
            this.cmb_fileselector.DisplayMember = "sefa";
            this.cmb_fileselector.FormattingEnabled = true;
            this.cmb_fileselector.Location = new System.Drawing.Point(53, 34);
            this.cmb_fileselector.Name = "cmb_fileselector";
            this.cmb_fileselector.Size = new System.Drawing.Size(123, 24);
            this.cmb_fileselector.TabIndex = 8;
            this.cmb_fileselector.SelectedIndexChanged += new System.EventHandler(this.cmb_fileselector_SelectedIndexChanged);
            // 
            // lst_txttext
            // 
            this.lst_txttext.FormattingEnabled = true;
            this.lst_txttext.ItemHeight = 16;
            this.lst_txttext.Location = new System.Drawing.Point(41, 142);
            this.lst_txttext.Name = "lst_txttext";
            this.lst_txttext.Size = new System.Drawing.Size(333, 132);
            this.lst_txttext.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Txt Metni";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_clearform
            // 
            this.btn_clearform.Location = new System.Drawing.Point(53, 428);
            this.btn_clearform.Name = "btn_clearform";
            this.btn_clearform.Size = new System.Drawing.Size(182, 23);
            this.btn_clearform.TabIndex = 20;
            this.btn_clearform.Text = "Formu Temizle";
            this.btn_clearform.UseVisualStyleBackColor = true;
            this.btn_clearform.Click += new System.EventHandler(this.btn_clearform_Click);
            // 
            // prg1_uploadstatus
            // 
            this.prg1_uploadstatus.Location = new System.Drawing.Point(204, 81);
            this.prg1_uploadstatus.Name = "prg1_uploadstatus";
            this.prg1_uploadstatus.Size = new System.Drawing.Size(182, 23);
            this.prg1_uploadstatus.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtx_wordtext
            // 
            this.rtx_wordtext.Location = new System.Drawing.Point(558, 142);
            this.rtx_wordtext.Name = "rtx_wordtext";
            this.rtx_wordtext.Size = new System.Drawing.Size(333, 132);
            this.rtx_wordtext.TabIndex = 21;
            this.rtx_wordtext.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Word Metni";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // prg2_uploadstatus
            // 
            this.prg2_uploadstatus.Location = new System.Drawing.Point(558, 81);
            this.prg2_uploadstatus.Name = "prg2_uploadstatus";
            this.prg2_uploadstatus.Size = new System.Drawing.Size(182, 23);
            this.prg2_uploadstatus.TabIndex = 24;
            // 
            // txt_worduniqnumber
            // 
            this.txt_worduniqnumber.Location = new System.Drawing.Point(558, 322);
            this.txt_worduniqnumber.Name = "txt_worduniqnumber";
            this.txt_worduniqnumber.ReadOnly = true;
            this.txt_worduniqnumber.Size = new System.Drawing.Size(123, 22);
            this.txt_worduniqnumber.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Farklı Kelime Sayısı";
            // 
            // btn_wordanlyz
            // 
            this.btn_wordanlyz.Location = new System.Drawing.Point(709, 321);
            this.btn_wordanlyz.Name = "btn_wordanlyz";
            this.btn_wordanlyz.Size = new System.Drawing.Size(182, 23);
            this.btn_wordanlyz.TabIndex = 29;
            this.btn_wordanlyz.Text = "Analiz Et";
            this.btn_wordanlyz.UseVisualStyleBackColor = true;
            this.btn_wordanlyz.Click += new System.EventHandler(this.btn_wordanlyz_Click);
            // 
            // txt_wordpuncnumber
            // 
            this.txt_wordpuncnumber.Location = new System.Drawing.Point(558, 384);
            this.txt_wordpuncnumber.Name = "txt_wordpuncnumber";
            this.txt_wordpuncnumber.ReadOnly = true;
            this.txt_wordpuncnumber.Size = new System.Drawing.Size(123, 22);
            this.txt_wordpuncnumber.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Noktalama İşaretleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Noktalama İşaretleri";
            // 
            // txt_textpuncnumber
            // 
            this.txt_textpuncnumber.Location = new System.Drawing.Point(51, 384);
            this.txt_textpuncnumber.Name = "txt_textpuncnumber";
            this.txt_textpuncnumber.ReadOnly = true;
            this.txt_textpuncnumber.Size = new System.Drawing.Size(123, 22);
            this.txt_textpuncnumber.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 481);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_wordrepeats);
            this.groupBox2.Controls.Add(this.lst_txtrepeats);
            this.groupBox2.Location = new System.Drawing.Point(953, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 481);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tekrarlar";
            // 
            // lst_wordrepeats
            // 
            this.lst_wordrepeats.FormattingEnabled = true;
            this.lst_wordrepeats.ItemHeight = 16;
            this.lst_wordrepeats.Location = new System.Drawing.Point(278, 23);
            this.lst_wordrepeats.Name = "lst_wordrepeats";
            this.lst_wordrepeats.Size = new System.Drawing.Size(218, 436);
            this.lst_wordrepeats.TabIndex = 1;
            // 
            // lst_txtrepeats
            // 
            this.lst_txtrepeats.FormattingEnabled = true;
            this.lst_txtrepeats.ItemHeight = 16;
            this.lst_txtrepeats.Location = new System.Drawing.Point(17, 23);
            this.lst_txtrepeats.Name = "lst_txtrepeats";
            this.lst_txtrepeats.Size = new System.Drawing.Size(218, 436);
            this.lst_txtrepeats.TabIndex = 0;
            // 
            // btn_txtupload
            // 
            this.btn_txtupload.Location = new System.Drawing.Point(204, 33);
            this.btn_txtupload.Name = "btn_txtupload";
            this.btn_txtupload.Size = new System.Drawing.Size(182, 24);
            this.btn_txtupload.TabIndex = 16;
            this.btn_txtupload.Text = "Txt Dosyası Yükle";
            this.btn_txtupload.UseVisualStyleBackColor = true;
            this.btn_txtupload.Click += new System.EventHandler(this.btn_txtupload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1505, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_textpuncnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_wordpuncnumber);
            this.Controls.Add(this.btn_wordanlyz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_worduniqnumber);
            this.Controls.Add(this.prg2_uploadstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtx_wordtext);
            this.Controls.Add(this.prg1_uploadstatus);
            this.Controls.Add(this.btn_clearform);
            this.Controls.Add(this.btn_txtupload);
            this.Controls.Add(this.cmb_fileselector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_txttext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_textuniqnumber);
            this.Controls.Add(this.btn_wordupload);
            this.Controls.Add(this.btn_txtanlyz);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_txtanlyz;
        private System.Windows.Forms.Button btn_wordupload;
        private System.Windows.Forms.TextBox txt_textuniqnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_fileselector;
        private System.Windows.Forms.ListBox lst_txttext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_clearform;
        private System.Windows.Forms.ProgressBar prg1_uploadstatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtx_wordtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar prg2_uploadstatus;
        private System.Windows.Forms.TextBox txt_worduniqnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_wordanlyz;
        private System.Windows.Forms.TextBox txt_wordpuncnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_textpuncnumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_wordrepeats;
        private System.Windows.Forms.ListBox lst_txtrepeats;
        private System.Windows.Forms.Button btn_txtupload;
    }
}

