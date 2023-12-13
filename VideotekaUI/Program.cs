using System;
using System.Windows.Forms;
using Videoteka.UI.Forms;

namespace VideotekaUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(loginForm.Korisnik));
                }
            }
        }
    }
}
