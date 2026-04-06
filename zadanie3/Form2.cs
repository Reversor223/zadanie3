using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form2 : Form
    {
        public string Imie => txtImie.Text;
        public string Nazwisko => txtNazwisko.Text;
        public int Wiek => int.Parse(txtWiek.Text);
        public string Stanowisko => comboStanowisko.SelectedItem?.ToString() ?? "";
        public Form2()
        {
            InitializeComponent();
            comboStanowisko.Items.Add("Programista");
            comboStanowisko.Items.Add("Kierownik");
            comboStanowisko.Items.Add("Tester");
            comboStanowisko.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Imie) ||
                string.IsNullOrWhiteSpace(Nazwisko) ||
                !int.TryParse(txtWiek.Text, out _))
            {
                MessageBox.Show("Uzupełnij poprawnie wszystkie pola.", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
