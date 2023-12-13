using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoteka.Abstract.Models;
using Videoteka.DB.Stores;

namespace Videoteka.UI.Forms
{
    public partial class LoginForm : Form
    {
        public Korisnik Korisnik { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            KorisnikStore korisnikStore = new KorisnikStore();

            Korisnik = korisnikStore.AutorizirajKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);

            if (Korisnik.Aktivan)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Neispravni podaci unosa!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
