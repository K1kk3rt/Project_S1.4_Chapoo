using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MODEL;

namespace DAL
{
    public class KeukenDAO
    {
        public static List<KeukenModel> GetKeukenOverzicht(List<KeukenModel> keukenoverzicht)
        {
            string query = "SELECT tafelID, aantal_personen, Bestelling.type, Bestelling.status, Voorraad.naam, Voorraad.beschrijving, Bestelling.opmerkingen, Bestelling.begintijd, Werknemers.voornaam, Werknemers.achternaam FROM tafel JOIN Werknemers ON tafel.werknemerID = Werknemers.werknemerID JOIN Bestelling ON tafel.klantID = Bestelling.bestellingID JOIN Voorraad ON Bestelling.ArtikelID = Voorraad.ArtikelID; ";


            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                var command = new SqlCommand(query, conn);

                

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KeukenModel keuken = LeesKeuken(reader);
                        keukenoverzicht.Add(keuken);
                    }
                }

            }

            return keukenoverzicht;
        }

        private static KeukenModel LeesKeuken(SqlDataReader reader)
        {
            KeukenModel keuken = new KeukenModel();

            keuken.TafelID = (int)reader["tafelID"];
            keuken.Aantal_Personen = (int)reader["aantal_personen"];
            keuken.Type = (string)reader["type"];
            keuken.Status = (string)reader["status"];
            keuken.NaamGerecht = (string)reader["naam"];
            keuken.BeschrijvingGerecht = (string)reader["beschrijving"];            
            if (reader.IsDBNull(6))
            {
                keuken.Opmerkingen = "geen opmerking";
            }
            else
            {
                keuken.Opmerkingen = (string)reader["opmerkingen"];
            }
            keuken.BeginTijd = (DateTime)reader["begintijd"];
            keuken.Voornaam_Werknemer = (string)reader["voornaam"];
            keuken.Achternaam_Werknemer = (string)reader["achternaam"];

            return keuken;
        }
    }
}
