using MySqlConnector;
using System;
using Videoteka.Abstract.Models;

namespace Videoteka.DB.Stores
{
    public class KorisnikStore
    {
        public Korisnik AutorizirajKorisnika(string korisnicko_ime, string lozinka)
        {
            var connectionManager = new SqlConnectionFactory();
            Korisnik korisnik = new Korisnik();

            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    string upit = String.Format("SELECT ime, prezime, email, aktivan FROM Korisnik " +
                        "WHERE korisnicko_ime = '{0}' AND lozinka = '{1}' AND Aktivan = 1", korisnicko_ime, lozinka);

                    using (var command = new MySqlCommand(upit, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                korisnik.Ime = reader.GetString("ime");
                                korisnik.Prezime = reader.GetString("prezime");
                                korisnik.Email = reader.GetString("email");
                                korisnik.Aktivan = reader.GetBoolean("aktivan");
                            }
                        }
                    }

                    connectionManager.CloseConnection(connection);
                }
            }
            return korisnik;
        }
    }
}
