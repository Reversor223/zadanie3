namespace zadanie3
{
    partial class Form2
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
            label1 = new Label();
            txtImie = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtWiek = new TextBox();
            txtNazwisko = new TextBox();
            comboStanowisko = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imie";
            // 
            // txtImie
            // 
            txtImie.Location = new Point(102, 23);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(100, 23);
            txtImie.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 167);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "Stanowisko";
            // 
            // txtWiek
            // 
            txtWiek.Location = new Point(102, 110);
            txtWiek.Name = "txtWiek";
            txtWiek.Size = new Size(100, 23);
            txtWiek.TabIndex = 5;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(102, 62);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(100, 23);
            txtNazwisko.TabIndex = 6;
            // 
            // comboStanowisko
            // 
            comboStanowisko.FormattingEnabled = true;
            comboStanowisko.Location = new Point(102, 159);
            comboStanowisko.Name = "comboStanowisko";
            comboStanowisko.Size = new Size(121, 23);
            comboStanowisko.TabIndex = 7;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(381, 12);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(115, 73);
            btnOK.TabIndex = 8;
            btnOK.Text = "Zatwierdź";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(381, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 73);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 285);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(comboStanowisko);
            Controls.Add(txtNazwisko);
            Controls.Add(txtWiek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtImie);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtImie;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtWiek;
        private TextBox txtNazwisko;
        private ComboBox comboStanowisko;
        private Button btnOK;
        private Button btnCancel;
    }
}