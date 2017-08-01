using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailEtDatagrid
{
    public class Document
    {
        int documentId;
        string cote;
        string typeDoc;
        DateTime dateAchat;
        bool disponible;
        string titre;
        string auteur;
        string genre;
        int nombrePages;
        string caution;

        public Document(int documentId, string cote, string typeDoc, DateTime dateAchat, bool disponible, string titre, string auteur, string genre, int nombrePages, string caution)
        {
            this.documentId = documentId;
            this.cote = cote;
            this.typeDoc = typeDoc;
            this.dateAchat = dateAchat;
            this.disponible = disponible;
            this.titre = titre;
            this.auteur = auteur;
            this.genre = genre;
            this.nombrePages = nombrePages;
            this.caution = caution;
        }

        public int DocumentId
        {
            get
            {
                return documentId;
            }

            set
            {
                documentId = value;
            }
        }

        public string Cote
        {
            get
            {
                return cote;
            }

            set
            {
                cote = value;
            }
        }

        public string TypeDoc
        {
            get
            {
                return typeDoc;
            }

            set
            {
                typeDoc = value;
            }
        }

        public DateTime DateAchat
        {
            get
            {
                return dateAchat;
            }

            set
            {
                dateAchat = value;
            }
        }

        public bool Disponible
        {
            get
            {
                return disponible;
            }

            set
            {
                disponible = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }

            set
            {
                auteur = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public int NombrePages
        {
            get
            {
                return nombrePages;
            }

            set
            {
                nombrePages = value;
            }
        }

        public string Caution
        {
            get
            {
                return caution;
            }

            set
            {
                caution = value;
            }
        }

        
    }
}
