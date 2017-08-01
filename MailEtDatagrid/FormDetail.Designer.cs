namespace MailEtDatagrid
{
    partial class FormDetail
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDateAchat = new System.Windows.Forms.Label();
            this.labelCote = new System.Windows.Forms.Label();
            this.labelDispo = new System.Windows.Forms.Label();
            this.labelNPCaution = new System.Windows.Forms.Label();
            this.labelTypeDoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Papyrus", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(360, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(125, 60);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "label1";
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteur.Location = new System.Drawing.Point(167, 88);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(81, 30);
            this.labelAuteur.TabIndex = 1;
            this.labelAuteur.Text = "Auteur :";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelGenre.Location = new System.Drawing.Point(209, 138);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(76, 30);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Genre :";
            // 
            // labelDateAchat
            // 
            this.labelDateAchat.AutoSize = true;
            this.labelDateAchat.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelDateAchat.Location = new System.Drawing.Point(544, 138);
            this.labelDateAchat.Name = "labelDateAchat";
            this.labelDateAchat.Size = new System.Drawing.Size(130, 30);
            this.labelDateAchat.TabIndex = 3;
            this.labelDateAchat.Text = "Date d\'achat : ";
            // 
            // labelCote
            // 
            this.labelCote.AutoSize = true;
            this.labelCote.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelCote.Location = new System.Drawing.Point(300, 196);
            this.labelCote.Name = "labelCote";
            this.labelCote.Size = new System.Drawing.Size(67, 30);
            this.labelCote.TabIndex = 4;
            this.labelCote.Text = "Cote :";
            // 
            // labelDispo
            // 
            this.labelDispo.AutoSize = true;
            this.labelDispo.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelDispo.Location = new System.Drawing.Point(407, 331);
            this.labelDispo.Name = "labelDispo";
            this.labelDispo.Size = new System.Drawing.Size(60, 30);
            this.labelDispo.TabIndex = 5;
            this.labelDispo.Text = "label6";
            // 
            // labelNPCaution
            // 
            this.labelNPCaution.AutoSize = true;
            this.labelNPCaution.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelNPCaution.Location = new System.Drawing.Point(625, 252);
            this.labelNPCaution.Name = "labelNPCaution";
            this.labelNPCaution.Size = new System.Drawing.Size(60, 30);
            this.labelNPCaution.TabIndex = 6;
            this.labelNPCaution.Text = "label7";
            // 
            // labelTypeDoc
            // 
            this.labelTypeDoc.AutoSize = true;
            this.labelTypeDoc.Font = new System.Drawing.Font("Papyrus", 14F);
            this.labelTypeDoc.Location = new System.Drawing.Point(210, 252);
            this.labelTypeDoc.Name = "labelTypeDoc";
            this.labelTypeDoc.Size = new System.Drawing.Size(178, 30);
            this.labelTypeDoc.TabIndex = 7;
            this.labelTypeDoc.Text = "Type de document :";
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 430);
            this.Controls.Add(this.labelTypeDoc);
            this.Controls.Add(this.labelNPCaution);
            this.Controls.Add(this.labelDispo);
            this.Controls.Add(this.labelCote);
            this.Controls.Add(this.labelDateAchat);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuteur);
            this.Controls.Add(this.labelTitre);
            this.Name = "FormDetail";
            this.Text = "FormDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDateAchat;
        private System.Windows.Forms.Label labelCote;
        private System.Windows.Forms.Label labelDispo;
        private System.Windows.Forms.Label labelNPCaution;
        private System.Windows.Forms.Label labelTypeDoc;
    }
}