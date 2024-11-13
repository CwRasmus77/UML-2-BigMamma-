using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_BigMamma
{
    public class ExtraToppings
    {
        public int ToppingId { get; set; }
        public string ToppingNavn { get; set; }
        public double Pris { get; set; }


        public ExtraToppings(int toppingID, string toppingnavn, double pris)
        {
            ToppingId = toppingID;
            ToppingNavn = toppingnavn;
            Pris = pris;
        }

        public override string ToString() { return ToppingId + " " + ToppingNavn + " " + Pris; }
    }


}
