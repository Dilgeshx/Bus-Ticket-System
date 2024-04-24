namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            cmbOtobus = new ComboBox();
            cmbNereden = new ComboBox();
            label2 = new Label();
            cmbNereye = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dtpTarih = new DateTimePicker();
            label5 = new Label();
            nudFiyat = new NumericUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rezerveEtToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(774, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(848, 633);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefon";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cinsiyet";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nereden";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nereye";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Koltuk No";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tarih";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(324, 78);
            label1.Name = "label1";
            label1.Size = new Size(153, 16);
            label1.TabIndex = 1;
            label1.Text = "Otobüs Firması Seçiniz";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // cmbOtobus
            // 
            cmbOtobus.FormattingEnabled = true;
            cmbOtobus.Items.AddRange(new object[] { "Metro Turizm", "Lüks Artvin", "Van Gölü" });
            cmbOtobus.Location = new Point(477, 71);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(183, 23);
            cmbOtobus.TabIndex = 2;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            // 
            // cmbNereden
            // 
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Çanakkale", "Diyarbakır", "Van", "Ağrı", "Erzurum", "Bursa", "Kocaeli" });
            cmbNereden.Location = new Point(128, 21);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(183, 23);
            cmbNereden.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label2.Location = new Point(8, 23);
            label2.Name = "label2";
            label2.Size = new Size(119, 16);
            label2.TabIndex = 3;
            label2.Text = "Başlangıç Noktası";
            label2.Click += label2_Click;
            // 
            // cmbNereye
            // 
            cmbNereye.FormattingEnabled = true;
            cmbNereye.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Çanakkale", "Diyarbakır", "Van", "Ağrı", "Erzurum", "Bursa", "Kocaeli" });
            cmbNereye.Location = new Point(128, 73);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(183, 23);
            cmbNereye.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.Location = new Point(9, 80);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 5;
            label3.Text = "Varış Noktası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(393, 248);
            label4.Name = "label4";
            label4.Size = new Size(39, 16);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(477, 241);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(183, 23);
            dtpTarih.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(393, 319);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 10;
            label5.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(477, 312);
            nudFiyat.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudFiyat.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(183, 23);
            nudFiyat.TabIndex = 11;
            nudFiyat.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(357, 387);
            button1.Name = "button1";
            button1.Size = new Size(188, 35);
            button1.TabIndex = 12;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNereye);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNereden);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(349, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 105);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "İstikamet";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rezerveEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            rezerveEtToolStripMenuItem.BackColor = SystemColors.ControlDark;
            rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            rezerveEtToolStripMenuItem.Size = new Size(127, 22);
            rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            rezerveEtToolStripMenuItem.Click += rezerveEtToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1634, 924);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(nudFiyat);
            Controls.Add(label5);
            Controls.Add(dtpTarih);
            Controls.Add(label4);
            Controls.Add(cmbOtobus);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ComboBox cmbOtobus;
        private ComboBox cmbNereden;
        private Label label2;
        private ComboBox cmbNereye;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTarih;
        private Label label5;
        private NumericUpDown nudFiyat;
        private Button button1;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}
