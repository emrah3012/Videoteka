using System.Windows.Forms;
using Videoteka.Abstract.Enums;
using Videoteka.Abstract.Models;
using Videoteka.DB.Stores;
using Videoteka.UI.Forms;

namespace VideotekaUI
{
    public partial class MainForm : Form
    {       
        public MainForm(Korisnik korisnik)
        {            
            InitializeComponent();

            lblDobrodosao.Text = string.Format("Dobrodošao {0} {1}!", korisnik.Ime, korisnik.Prezime);
        }

    }
}
