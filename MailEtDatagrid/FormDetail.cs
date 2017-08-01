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
    public partial class FormDetail : Form
    {
        public FormDetail(Document doc)
        {
            InitializeComponent();
            labelTitre.Text = doc.Titre;
            labelAuteur.Text += doc.Auteur;
            labelCote.Text += doc.Cote;
            labelDateAchat.Text += doc.DateAchat.ToShortDateString();
            labelGenre.Text += doc.Genre;
            switch (doc.TypeDoc)
            {
                case "D":
                    labelTypeDoc.Text += "DVD";
                        break;
                case "L":
                    labelTypeDoc.Text += "Livre";
                    break;
                default:
                    break;
            }
            switch (doc.NombrePages)
            {
                case 0:
                    labelNPCaution.Text = "Caution : "+ doc.Caution;
                    break;
                default:
                    labelNPCaution.Text = "Nombre de pages : " + doc.NombrePages;
                    break;
            }
            switch (doc.Disponible)
            {
                case true:
                    labelDispo.Text = "Le document est disponible";
                    labelDispo.ForeColor = Color.Green;
                    break;
                default:
                    labelDispo.Text = "Le document n'est pas disponible";
                    labelDispo.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
