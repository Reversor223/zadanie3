using System;
using System.Data;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace zadanie3
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private int nextID = 1;
        
        public Form1()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Imie", typeof(string));
            table.Columns.Add("Nazwisko", typeof(string));
            table.Columns.Add("Wiek", typeof(int));
            table.Columns.Add("Stanowisko", typeof(string));

            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var addForm = new Form2())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    DataTable table = (DataTable)bindingSource.DataSource;
                    table.Rows.Add(nextID++, addForm.Imie, addForm.Nazwisko, addForm.Wiek, addForm.Stanowisko);
                }
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void btnZapisCSV_Click(object sender, EventArgs e)
        {
            using var dlg = new SaveFileDialog();
            dlg.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            dlg.Title = "Wybierz lokalizacjê zapisu pliku CSV";

            if (dlg.ShowDialog() == DialogResult.OK)
                ExportToCSV(dataGridView1, dlg.FileName);
        }

        private void btnOdczytCSV_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            dlg.Title = "Wybierz plik CSV do wczytania";

            if (dlg.ShowDialog() == DialogResult.OK)
                LoadCSVToDataGridView(dlg.FileName);
        }

        private void ExportToCSV(DataGridView dgv, string filePath)
        {
            // nag³ówek
            string csv = string.Join(",", dgv.Columns.Cast<DataGridViewColumn>()
                                   .Select(c => c.HeaderText)) + Environment.NewLine;

            // wiersze
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    csv += string.Join(",", row.Cells.Cast<DataGridViewCell>()
                                  .Select(c => c.Value)) + Environment.NewLine;
                }
            }

            File.WriteAllText(filePath, csv);
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0) return;

            string[] headers = lines[0].Split(',');

            DataTable table = new DataTable();
            foreach (string h in headers)
                table.Columns.Add(h);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                string[] values = lines[i].Split(',');
                table.Rows.Add(values);
            }

            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;

            // aktualizacja nextID
            if (table.Rows.Count > 0)
            {
                nextID = table.AsEnumerable().Max(r => r.Field<int>("ID")) + 1;
            }
            else
            {
                nextID = 1;
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.Title = "Wybierz lokalizacjê zapisu dla pliku XML";
                if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    var list = new List<Person>();
                    DataTable dt = (DataTable)dataGridView1.DataSource;
                    foreach (DataRow r in dt.Rows)
                    {

                    }
                }
            }


        }
       
           
          
            public void SerializeToXML(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, this);
                }
                Console.WriteLine("Obiekt zostal zserializowany do pliku XML");
            }

            public static Person DeserializeFromXML(string fileName)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                using (TextReader reader = new StreamReader(fileName))
                {
                    Person person = (Person)serializer.Deserialize(reader);
                    Console.WriteLine("Obiekt zostal odczytany z pliku XML.");
                    return person;
                }
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Imie: " + Imie);
                Console.WriteLine("Nazwisko: " + Nazwisko);
                Console.WriteLine("Wiek: " + Wiek);
            }
            /* public static void Main(string[] args)
             {
                 Person person1 = new Person("Jan", "Kowalski", 30);
                 person1.SerializeToXML("person.xml");
                 Person person2 = Person.DeserializeFromXML("person.xml");

                 if (person2 == null)
                 {
                     person2.DisplayInfo();
                 }
             }*/
        }
    
    }

    

