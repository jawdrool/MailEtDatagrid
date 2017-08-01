using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MailEtDatagrid
{
    public class Bdd
    {
        private MySqlConnection connection;
        public  Bdd()
        {
            this.InitConnexion();
        }
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=cdet; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        public List<Document> GetDocuments()
        {
            List<Document> documents = new List<Document>();
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `document`";
                MySqlDataReader msdr = cmd.ExecuteReader();
                //msdr.Read();
                while (msdr.Read())
                {
                    
                    documents.Add(new Document(msdr.GetInt32(0), msdr.GetString(1), msdr.GetString(2), msdr.GetDateTime(3), msdr.GetBoolean(4), msdr.GetString(5), msdr.GetString(6), msdr.GetString(7), msdr.IsDBNull(8)?0: msdr.GetInt32(8), msdr.IsDBNull(9)?"0": msdr.GetString(9)));
                }
                

                this.connection.Close();
            }
            catch (Exception)
            {
                
               // throw;
            }
            return documents;
        }
        public List<Document> GetDocumentsParAuteur()
        {
            List<Document> documents = new List<Document>();
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `document` ORDER BY `document`.`Auteur` ASC";
                MySqlDataReader msdr = cmd.ExecuteReader();
                //msdr.Read();
                while (msdr.Read())
                {

                    documents.Add(new Document(msdr.GetInt32(0), msdr.GetString(1), msdr.GetString(2), msdr.GetDateTime(3), msdr.GetBoolean(4), msdr.GetString(5), msdr.GetString(6), msdr.GetString(7), msdr.IsDBNull(8) ? 0 : msdr.GetInt32(8), msdr.IsDBNull(9) ? "0" : msdr.GetString(9)));
                }


                this.connection.Close();
            }
            catch (Exception)
            {

                // throw;
            }
            return documents;
        }
        public List<Document> GetDocumentsParTitre()
        {
            List<Document> documents = new List<Document>();
            try
            {
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM `document` ORDER BY `document`.`Titre` ASC";
                MySqlDataReader msdr = cmd.ExecuteReader();
                //msdr.Read();
                while (msdr.Read())
                {

                    documents.Add(new Document(msdr.GetInt32(0), msdr.GetString(1), msdr.GetString(2), msdr.GetDateTime(3), msdr.GetBoolean(4), msdr.GetString(5), msdr.GetString(6), msdr.GetString(7), msdr.IsDBNull(8) ? 0 : msdr.GetInt32(8), msdr.IsDBNull(9) ? "0" : msdr.GetString(9)));
                }


                this.connection.Close();
            }
            catch (Exception)
            {

                // throw;
            }
            return documents;
        }
    }
    
}
