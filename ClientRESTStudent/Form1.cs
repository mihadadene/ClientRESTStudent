using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRESTStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMoy_Click(object sender, EventArgs e)
        {
            lbMoyenne.Text = ClientStd.GetMoyenne().ToString();
        }

        private void btReussis_Click(object sender, EventArgs e)
        {
            List<Student>.Enumerator liste = ClientStd.GetReussis().GetEnumerator();
            string s = "";
            while (liste.MoveNext())
            {
                s += liste.Current + "\n";
            }
            lbReussis.Text = s;
        }
        private void btRech_Click(object sender, EventArgs e)
        {
            if(tbNom.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez saisir un text dans le nom");
                return;
            }
            List<Student>.Enumerator liste = ClientStd.GetParNom(tbNom.Text).GetEnumerator();
            string s = "";
            while (liste.MoveNext())
            {
                s += liste.Current + "\n";
            }
            lbRechNom.Text = s;
        }

        private void btRechNda_Click(object sender, EventArgs e)
        {
    if(tbNda.Text.Trim() == "")
            {
                MessageBox.Show("Vous devez saisir un text dans le nom");
                return;
            }
            Student std = ClientStd.GetParNDA(tbNda.Text);
            if(std != null){
                lbRechNda.Text = std.ToString();
            }
            else
            {
                lbRechNda.Text = "Introuvable";
            }
        }

    }
}
