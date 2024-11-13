using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2_BigMamma
{
    public class ExtraToppiongsMenu
    {
        public Dictionary<int, ExtraToppings> Toppings = new Dictionary<int, ExtraToppings>();

        public ExtraToppiongsMenu()
        {
            Toppings.Add(1, new ExtraToppings(1, "Ananas", 10));
            Toppings.Add(2, new ExtraToppings(2, "Artiskok", 10));
            Toppings.Add(3, new ExtraToppings(3, "Paprika", 10));
            Toppings.Add(4, new ExtraToppings(4, "Onion", 10));
            Toppings.Add(5, new ExtraToppings(5, "Oliven", 10));
            Toppings.Add(6, new ExtraToppings(6, "Asparagus", 10));
            Toppings.Add(7, new ExtraToppings(7, "Pesto", 10));
            Toppings.Add(8, new ExtraToppings(8, "Chili i bæger", 10));
            Toppings.Add(9, new ExtraToppings(9, "Garlic i bæger", 10));

            //Console.WriteLine(\n);

            Toppings.Add(10, new ExtraToppings(10, "Cheese", 15));
            Toppings.Add(11, new ExtraToppings(11, "Ham", 15));
            Toppings.Add(12, new ExtraToppings(12, "Mushrooms", 15));
            Toppings.Add(13, new ExtraToppings(13, "Bacon", 15));
            Toppings.Add(14, new ExtraToppings(14, "Cocktail sausages", 15));
            Toppings.Add(15, new ExtraToppings(15, "Rucola", 15));
            Toppings.Add(16, new ExtraToppings(16, "Fresh Tomato", 15));
            Toppings.Add(17, new ExtraToppings(17, "Parmigiano", 15));

            //Console.WriteLine(\n);

            Toppings.Add(18, new ExtraToppings(18, "Gorgonzola", 20));
            Toppings.Add(19, new ExtraToppings(19, "Pepperoni", 20));
            Toppings.Add(20, new ExtraToppings(20, "Anchovies", 20));
            Toppings.Add(21, new ExtraToppings(21, "Shrimp", 20));
            Toppings.Add(22, new ExtraToppings(22, "Meat strips", 20));
            Toppings.Add(23, new ExtraToppings(23, "Parma ham", 20));
            Toppings.Add(24, new ExtraToppings(24, "Salat with tomato", 20));
            Toppings.Add(25, new ExtraToppings(25, "Cucumber with dressing", 20));
            Toppings.Add(26, new ExtraToppings(26, "Mixed Mushrooms", 20));
            Toppings.Add(27, new ExtraToppings(27, "Fresh Mozzarella", 20));
            Toppings.Add(28, new ExtraToppings(28, "Fresh Meat sauce", 20));

        }

        public void AddToppings(ExtraToppings toppings)
        {
            if (!Toppings.ContainsKey(toppings.ToppingId))
                Toppings.Add(toppings.ToppingId, toppings);
        }

        public bool RemoveToppings(int toppingId)
        {
            if (Toppings.ContainsKey(toppingId))
            {
                return Toppings.Remove(toppingId);
            }
            return false;
        }

        public ExtraToppings GetToppingsById(int toppingId)
        {
            if (Toppings.ContainsKey(toppingId))
                return Toppings[toppingId];
            return null!;
        }

        public ExtraToppings Update(int toppingId, ExtraToppings toppings)
        {
            foreach (ExtraToppings t in Toppings.Values)
            {
                if (toppingId == t.ToppingId)
                {
                    t.ToppingId = toppingId;
                    t.Pris = toppings.Pris;
                }
            }
            return toppings;
        }

        //public void RemoveById(int id)
        //{

        //    if (id != null)
        //    {
        //        Toppings.Remove(id);
        //    }

        //}
        //public void OpdaterToppingNavn(int id, string navn)
        //{
        //    Toppings.ElementAt(id).Value.ToppingNavn = navn;
        //}

        //public void OpdaterPris(int id, double pris)
        //{
        //    Toppings.ElementAt(id).Value.Pris = pris;
        //}

        public void PrintMenu()
        {

            foreach (KeyValuePair<int, ExtraToppings> entry in Toppings)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}