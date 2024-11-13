using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_BigMamma
{
    public class Ordrelinje
    {

        public int _orderNumber { get; }
        public string _kundeNavn { get; }
        public string _toppings { get; }
        public string _pizzaNavn { get; }
        public int Telefonnummer { get; }
        public string Adresse { get; }
        public string _kommentar { get; }
        public double _pris { get; }


        public Ordrelinje(Ordre ordre, Kunde kunde, ExtraToppings extraToppings)
        {
            _orderNumber = ordre.OrdreNummer;
            _kundeNavn = kunde.KundeNavn;
            _toppings = extraToppings.ToppingNavn;
            _pizzaNavn = ordre._pizza.PizzaNavn;
            Telefonnummer = kunde.TelefonNummer;
            Adresse = kunde.Adresse;
            _kommentar = ordre._kommentar;
            _pris = ordre.Pris + extraToppings.Pris;
        }
        public override string ToString()
        {
            return $"Ordrenummer {_orderNumber} - Kunde: {_kundeNavn}  - Extra toppings: {_toppings} - Pizza Navn: {_pizzaNavn} - Telefon nummer: {Telefonnummer} - Adresse: {Adresse} - Kunde Kommentar: {_kommentar} - Total Pris: {_pris}";
        }
    }
}

