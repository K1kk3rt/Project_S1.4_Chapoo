using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class KeukenModel
    {
        public int TafelID { get; set; }
        public int Aantal_Personen { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string NaamGerecht { get; set; }
        public string BeschrijvingGerecht { get; set; }
        public string Opmerkingen { get; set; }
        public DateTime BeginTijd { get; set; }
        public string Voornaam_Werknemer { get; set; }
        public string Achternaam_Werknemer { get; set; }

        public static List<KeukenModel> keukenoverzicht = new List<KeukenModel>();

    }
}
