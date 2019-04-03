using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TpFenetreMereFille
{
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;
        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            //btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnClose.Click += new EventHandler(btnClose_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            nouvelleFille.FormClosing += new FormClosingEventHandler(nouvelleFille_FormClosing);
            this.lesFilles.Add(nouvelleFille);
            this.lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
            
        }

        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }

        void nouvelleFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            FFille laFille = (FFille)sender;
            int position = lesFilles.IndexOf(laFille);
            lesFilles.RemoveAt(position);
            this.lbLesFilles.Items.RemoveAt(position);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                lesFilles[position].Show();
            }
        }
        public string GetNomMere
        {
            get
            {
                return nomMere;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                this.lesFilles[position].Close();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            int position = lbLesFilles.SelectedIndex;
            if (position != -1)
            {
                this.lesFilles[position].ShowDialog();
            }
        }
        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(ffille);
            if (position != -1)
            {
                lesFilles[position] = ffille;
                lbLesFilles.Items[position] = nouveauNom;
            }
        }
    }
}
