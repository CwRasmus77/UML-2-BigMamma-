using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_BigMamma
{
    public class PizzaMenu
    {
        public Dictionary<int, Pizza> Pizzas = new Dictionary<int, Pizza>();

        public PizzaMenu()
        {
            Pizzas.Add(1, new Pizza(1, "Margherita", "Tomato & Cheese", 69));
            Pizzas.Add(2, new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75));
            Pizzas.Add(3, new Pizza(3, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80));
            Pizzas.Add(4, new Pizza(4, "Calzone", "Baked pizza with tomato, cheese, ham & mushrooms", 80));
            Pizzas.Add(5, new Pizza(5, "Quattro Stagioni", "Tomato, cheese, ham, mushrooms, shrimp & peppers", 85));
            Pizzas.Add(6, new Pizza(6, "Marinara", "Tomato, cheese & shrimp, mussels & garlic", 85));
            Pizzas.Add(7, new Pizza(7, "Vegetarian", "Tomato, cheese & vegetables", 80));
            Pizzas.Add(8, new Pizza(8, "Italiana", "Tomato, cheese, Onion & meat sauce", 85));
            Pizzas.Add(9, new Pizza(9, "Gorgonzola", "Tomato, gorgonzola, onion & mushroom", 85));
            Pizzas.Add(10, new Pizza(10, "Contadina", "Tomato, cheese, mushrooms & olives", 75));
            Pizzas.Add(11, new Pizza(11, "Naples", "Tomato, cheese, anchovies & olives", 79));
            Pizzas.Add(12, new Pizza(12, "Vichinga", "Tomato, cheese, ham & mushrooms, peppers, garlic & chili (strong)", 80));
            Pizzas.Add(13, new Pizza(13, "Calzone special", "Tomato, cheese, shrimp, ham & meat sauce", 80));
            Pizzas.Add(14, new Pizza(14, "Esotica", "Tomato, cheese, ham, shrimp & ananas", 80));
            Pizzas.Add(15, new Pizza(15, "Tonno", "Tomato, cheese, tuna & shrimp", 85));
            Pizzas.Add(16, new Pizza(16, "Sardegna", "Tomato, cheese, cocktail sausages, bacon,onions & eggs", 80));
            Pizzas.Add(17, new Pizza(17, "Romana", "Tomato, cheese, ham, bacon & onion", 78));
            Pizzas.Add(18, new Pizza(18, "Sole", "Tomato, cheese, ham, bacon & eggs", 78));
            Pizzas.Add(19, new Pizza(19, "Big Mamma", "Tomato, gorgonzola, shrimp, asparagus & parma ham", 90));


        }

        public void AddPizza(Pizza pizza)
        {
            if (!Pizzas.ContainsKey(pizza.PizzaId))
                Pizzas.Add(pizza.PizzaId, pizza);
        }

        public bool RemovePizzas(int pizzaId)
        {
            if (Pizzas.ContainsKey(pizzaId))
            {
                return Pizzas.Remove(pizzaId);
            }
            return false;
        }

        public Pizza GetPizzaBuyId(int pizzaId)
        {
            if (Pizzas.ContainsKey(pizzaId))
                return Pizzas[pizzaId];
            return null;

        }

        public Pizza Update(int pizzaId, Pizza pizza)
        {
            foreach (Pizza p in Pizzas.Values)
            {
                if (pizzaId == p.PizzaId)
                {
                    p.PizzaNavn = pizza.PizzaNavn;
                    p.PizzaPris = pizza.PizzaPris;
                    p.PizzaBeskrivelse = pizza.PizzaBeskrivelse;
                  
                   
                }
                
            }
            return pizza;
        }

        

        //public void RemoveById(int id)
        //{

        //    if (id != null)
        //    {
        //        Pizzas.Remove(id);
        //    }

        //}
        //public void OpdaterNavn(int id, string navn)
        //{
        //    Pizzas.ElementAt(id).Value.PizzaNavn = navn;
        //}
        //public void OpdaterBeskrivelse(int id, string beskrivelse)
        //{
        //    Pizzas.ElementAt(id).Value.PizzaBeskrivelse = beskrivelse;
        //}
        //public void OpdaterPris(int id, double pris)
        //{
        //    Pizzas.ElementAt(id).Value.PizzaPris = pris;
        //}

        public List<Pizza> FindPizzaByToppings(string toppings)
        {
            List<Pizza> pizzas = new List<Pizza>();

            foreach (KeyValuePair<int, Pizza> entry in Pizzas)

            {
                if (entry.Value.PizzaBeskrivelse.ToLower().Contains(toppings.ToLower()))
                {
                    pizzas.Add(entry.Value);
                }

            }
            PrintToppings(pizzas);
            return pizzas;
        }

        public void PrintToppings(List<Pizza> list)
        {
            foreach (Pizza pizza in list)
            {
                Console.WriteLine(pizza);
            }
        }




        public void PrintMenu()
        {

            foreach (KeyValuePair<int, Pizza> entry in Pizzas)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
