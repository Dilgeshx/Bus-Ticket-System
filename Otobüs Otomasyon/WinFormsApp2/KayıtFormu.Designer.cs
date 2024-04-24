namespace WinFormsApp2
{
    partial class KayıtFormu
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
            layer1 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            layer2 = new Label();
            label3 = new Label();
            mskdTelefon = new MaskedTextBox();
            rdbBay = new RadioButton();
            rdbBayan = new RadioButton();
            btnTamam = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // layer1
            // 
            layer1.AutoSize = true;
            layer1.Location = new Point(137, 67);
            layer1.Name = "layer1";
            layer1.Size = new Size(29, 15);
            layer1.TabIndex = 0;
            layer1.Text = "İsim";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(191, 59);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(138, 23);
            txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(191, 108);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(138, 23);
            txtSoyisim.TabIndex = 3;
            // 
            // layer2
            // 
            layer2.AutoSize = true;
            layer2.Location = new Point(137, 116);
            layer2.Name = "layer2";
            layer2.Size = new Size(48, 15);
            layer2.TabIndex = 2;
            layer2.Text = "Soyisim";
            layer2.Click += txtSoyisim_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 167);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            label3.Click += label3_Click;
            // 
            // mskdTelefon
            // 
            mskdTelefon.Location = new Point(191, 159);
            mskdTelefon.Mask = "(999) 000-0000";
            mskdTelefon.Name = "mskdTelefon";
            mskdTelefon.Size = new Size(138, 23);
            mskdTelefon.TabIndex = 6;
            // 
            // rdbBay
            // 
            rdbBay.AutoSize = true;
            rdbBay.Location = new Point(147, 211);
            rdbBay.Name = "rdbBay";
            rdbBay.Size = new Size(44, 19);
            rdbBay.TabIndex = 7;
            rdbBay.Text = "Bay";
            rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            rdbBayan.AutoSize = true;
            rdbBayan.Location = new Point(315, 211);
            rdbBayan.Name = "rdbBayan";
            rdbBayan.Size = new Size(57, 19);
            rdbBayan.TabIndex = 8;
            rdbBayan.Text = "Bayan";
            rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(315, 236);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(75, 23);
            btnTamam.TabIndex = 9;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(147, 236);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(75, 23);
            btnIptal.TabIndex = 10;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // KayıtFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(472, 342);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(rdbBayan);
            Controls.Add(rdbBay);
            Controls.Add(mskdTelefon);
            Controls.Add(label3);
            Controls.Add(txtSoyisim);
            Controls.Add(layer2);
            Controls.Add(txtIsim);
            Controls.Add(layer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "KayıtFormu";
            Text = "KayıtFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label layer1;
        private Label layer2;
        private Label label3;
        private Button btnTamam;
        private Button btnIptal;
        public TextBox txtIsim;
        public TextBox txtSoyisim;
        public MaskedTextBox mskdTelefon;
        public RadioButton rdbBay;
        public RadioButton rdbBayan;
    }
}