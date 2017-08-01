using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailEtDatagrid
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LeMailEstBon(textBox1.Text))
            {
                MessageBox.Show("Le mail est bon");
            }else MessageBox.Show("Le mail n'est pas bon");

        }
        bool LeMailEstBon(string mail)
        {
            string pattern = @"^[-a-z0-9A-Z_]{2,}(\.[-a-z0-9A-Z_]+)*@[-a-z0-9A-Z_]{2,}\.[a-zA-Z]{2,}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(mail);
        }
    }
}
