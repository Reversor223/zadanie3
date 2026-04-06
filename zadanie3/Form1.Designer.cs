namespace zadanie3
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
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            btnZapisCSV = new Button();
            btnOdczytCSV = new Button();
            btnUsun = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(614, 103);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(124, 40);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnZapisCSV
            // 
            btnZapisCSV.Location = new Point(233, 340);
            btnZapisCSV.Name = "btnZapisCSV";
            btnZapisCSV.Size = new Size(176, 43);
            btnZapisCSV.TabIndex = 2;
            btnZapisCSV.Text = "Zapis do .csv";
            btnZapisCSV.UseVisualStyleBackColor = true;
            btnZapisCSV.Click += btnZapisCSV_Click;
            // 
            // btnOdczytCSV
            // 
            btnOdczytCSV.Location = new Point(554, 340);
            btnOdczytCSV.Name = "btnOdczytCSV";
            btnOdczytCSV.Size = new Size(184, 43);
            btnOdczytCSV.TabIndex = 3;
            btnOdczytCSV.Text = "Odczyt z .csv";
            btnOdczytCSV.UseVisualStyleBackColor = true;
            btnOdczytCSV.Click += btnOdczytCSV_Click;
            // 
            // btnUsun
            // 
            btnUsun.Location = new Point(614, 164);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(124, 41);
            btnUsun.TabIndex = 4;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsun);
            Controls.Add(btnOdczytCSV);
            Controls.Add(btnZapisCSV);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDodaj;
        private Button btnZapisCSV;
        private Button btnOdczytCSV;
        private Button btnUsun;
    }
}
