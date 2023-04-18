namespace Calculator
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
            labelEkran = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonVirgul = new Button();
            buttonCarpi = new Button();
            buttonBolme = new Button();
            buttonEksi = new Button();
            buttonArti = new Button();
            buttonDel = new Button();
            buttonC = new Button();
            buttonEsittir = new Button();
            buttonNegatif = new Button();
            SuspendLayout();
            // 
            // labelEkran
            // 
            labelEkran.Anchor = AnchorStyles.Right;
            labelEkran.BackColor = SystemColors.ControlLight;
            labelEkran.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelEkran.ForeColor = SystemColors.ActiveCaptionText;
            labelEkran.Location = new Point(12, 40);
            labelEkran.Name = "labelEkran";
            labelEkran.Size = new Size(378, 111);
            labelEkran.TabIndex = 0;
            labelEkran.Text = "0";
            labelEkran.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(15, 479);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(111, 479);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 255);
            button3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(207, 479);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 255);
            button4.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(15, 383);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 255);
            button5.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(111, 383);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 255);
            button6.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(207, 383);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 255);
            button7.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(15, 287);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 255);
            button8.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(111, 287);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 255);
            button9.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(207, 287);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(255, 128, 255);
            button0.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(111, 575);
            button0.Name = "button0";
            button0.Size = new Size(90, 90);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonVirgul
            // 
            buttonVirgul.BackColor = Color.FromArgb(255, 128, 255);
            buttonVirgul.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVirgul.Location = new Point(207, 575);
            buttonVirgul.Name = "buttonVirgul";
            buttonVirgul.Size = new Size(90, 90);
            buttonVirgul.TabIndex = 11;
            buttonVirgul.Text = ",";
            buttonVirgul.UseVisualStyleBackColor = false;
            buttonVirgul.Click += buttonVirgul_Click;
            // 
            // buttonCarpi
            // 
            buttonCarpi.BackColor = Color.FromArgb(255, 128, 255);
            buttonCarpi.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCarpi.Location = new Point(300, 191);
            buttonCarpi.Name = "buttonCarpi";
            buttonCarpi.Size = new Size(90, 90);
            buttonCarpi.TabIndex = 12;
            buttonCarpi.Text = "X";
            buttonCarpi.UseVisualStyleBackColor = false;
            buttonCarpi.Click += buttonCarpi_Click;
            // 
            // buttonBolme
            // 
            buttonBolme.BackColor = Color.FromArgb(255, 128, 255);
            buttonBolme.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBolme.Location = new Point(207, 191);
            buttonBolme.Name = "buttonBolme";
            buttonBolme.Size = new Size(90, 90);
            buttonBolme.TabIndex = 13;
            buttonBolme.Text = "÷";
            buttonBolme.UseVisualStyleBackColor = false;
            buttonBolme.Click += buttonBolme_Click;
            // 
            // buttonEksi
            // 
            buttonEksi.BackColor = Color.FromArgb(255, 128, 255);
            buttonEksi.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEksi.Location = new Point(303, 287);
            buttonEksi.Name = "buttonEksi";
            buttonEksi.Size = new Size(90, 90);
            buttonEksi.TabIndex = 15;
            buttonEksi.Text = "-";
            buttonEksi.UseVisualStyleBackColor = false;
            buttonEksi.Click += buttonEksi_Click;
            // 
            // buttonArti
            // 
            buttonArti.BackColor = Color.FromArgb(255, 128, 255);
            buttonArti.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonArti.Location = new Point(303, 383);
            buttonArti.Name = "buttonArti";
            buttonArti.Size = new Size(90, 186);
            buttonArti.TabIndex = 16;
            buttonArti.Text = "+";
            buttonArti.UseVisualStyleBackColor = false;
            buttonArti.Click += buttonArti_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.FromArgb(255, 128, 128);
            buttonDel.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDel.Location = new Point(111, 191);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(90, 90);
            buttonDel.TabIndex = 18;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(255, 128, 128);
            buttonC.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.Location = new Point(15, 191);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(90, 90);
            buttonC.TabIndex = 19;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonEsittir
            // 
            buttonEsittir.BackColor = Color.FromArgb(255, 128, 255);
            buttonEsittir.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEsittir.Location = new Point(303, 578);
            buttonEsittir.Name = "buttonEsittir";
            buttonEsittir.Size = new Size(90, 90);
            buttonEsittir.TabIndex = 20;
            buttonEsittir.Text = "=";
            buttonEsittir.UseVisualStyleBackColor = false;
            buttonEsittir.Click += buttonEsittir_Click;
            // 
            // buttonNegatif
            // 
            buttonNegatif.BackColor = Color.FromArgb(255, 128, 255);
            buttonNegatif.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNegatif.Location = new Point(12, 578);
            buttonNegatif.Name = "buttonNegatif";
            buttonNegatif.Size = new Size(90, 90);
            buttonNegatif.TabIndex = 21;
            buttonNegatif.Text = "+/-";
            buttonNegatif.UseVisualStyleBackColor = false;
            buttonNegatif.Click += buttonNegatif_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(406, 670);
            Controls.Add(buttonNegatif);
            Controls.Add(buttonEsittir);
            Controls.Add(buttonC);
            Controls.Add(buttonDel);
            Controls.Add(buttonArti);
            Controls.Add(buttonEksi);
            Controls.Add(buttonBolme);
            Controls.Add(buttonCarpi);
            Controls.Add(buttonVirgul);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelEkran);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Hesap Makinesi";
            ResumeLayout(false);
        }

        #endregion

        private Label labelEkran;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonVirgul;
        private Button buttonCarpi;
        private Button buttonBolme;
        private Button buttonEksi;
        private Button buttonArti;
        private Button buttonDel;
        private Button buttonC;
        private Button buttonEsittir;
        private Button buttonNegatif;
    }
}