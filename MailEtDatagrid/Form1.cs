using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MailEtDatagrid
{
    public partial class Form1 : Form
    {
        List<Document> docs;
        List<string> auteurs=new List<string>();
        List<string> titres = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Bdd bdd = new Bdd();
            docs=bdd.GetDocuments();
            
            foreach (Document d in docs)
            {
                auteurs.Add(d.Auteur);
                titres.Add(d.Titre);

            }
            AutoCompleteStringCollection auteursACSC = new AutoCompleteStringCollection();
            auteursACSC.AddRange(auteurs.ToArray());
            comboBox1.AutoCompleteCustomSource = auteursACSC;
            comboBox1.DataSource = docs;
            comboBox1.ValueMember = "Auteur";
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection titresACSC = new AutoCompleteStringCollection();
            titresACSC.AddRange(titres.ToArray());
            comboBox2.AutoCompleteCustomSource = titresACSC;
            comboBox2.DataSource = docs;
            comboBox2.ValueMember = "Titre";
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dataGridView1.DataSource = docs;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMail fm = new FormMail();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormDetail fd = new FormDetail(dataGridView1.SelectedRows[0].DataBoundItem as Document);
                fd.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<Document> doc = docs.Where(x => x.Disponible == true).ToList();
            int i =rand.Next(0, doc.Count);
            FormDetail fd = new FormDetail(doc[i]);
            fd.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMail fm = new FormMail();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Bdd bdd = new Bdd();
            switch (button4.Text)
            {
                case "Classer par Auteur":
                    docs = bdd.GetDocumentsParAuteur();
                    button4.Text = "Classer par Titre";
                    break;
                default:
                    docs = bdd.GetDocuments();
                    button4.Text = "Classer par Auteur";
                    break;
            }
            
            dataGridView1.DataSource = docs;
            comboBox1.DataSource = docs;
            comboBox2.DataSource = docs;
        }
    }
}
