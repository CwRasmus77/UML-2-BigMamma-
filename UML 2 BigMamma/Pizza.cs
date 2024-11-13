﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_BigMamma
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string PizzaNavn { get; set; }
        public string PizzaBeskrivelse { get; set; }
        public double PizzaPris { get; set; }


        public Pizza(int pizzaid, string pizzanavn, string pizzabeskrivelse, double pizzapris)
        {
            PizzaId = pizzaid;
            PizzaNavn = pizzanavn;
            PizzaBeskrivelse = pizzabeskrivelse;
            PizzaPris = pizzapris;
        }
        //public void Start()
        //{
        //    Pizza pizza1 = new Pizza(1, "Margherita", "Tomat & ost", 69.00);
        //    Console.WriteLine(pizza1);
        //    Pizza pizza14 = new Pizza(14, "Esotica", "Tomato, ost, skinke, rejer & pineapple ", 80.00);
        //    Console.WriteLine(pizza14);
        //    Pizza pizza19 = new Pizza(19, "Big Mamma", "Tomato, gorgonzola, shrimp, asparagus & parma ham ", 90.00);
        //    Console.WriteLine(pizza19);
        //}

        public override string ToString() { return PizzaId + " " + PizzaNavn + " " + PizzaBeskrivelse + " " + PizzaPris + "kr "; }

    }


}
