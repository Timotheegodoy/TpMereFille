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
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            // this.Load += new EventHandler(FFille_Load);
            this.btnChanger.Click += new EventHandler(btnChanger_Click);
        }

        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur" + this.monNom);
        }

        private void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maMere.GetNomMere);
        }
        private void btnChanger_Click(object sender, EventArgs e)
        {
            this.Text = tbChanger.Text;
            this.Name = tbChanger.Text;
            maMere.MaFilleChangeDeNom(this, this.Name);
        }

    }
}
