
using UML_2_BigMamma;

Store store = new Store();
store.start();

CustomerFile kundeliste = new CustomerFile();
kundeliste.AddKunde(new Kunde(11, "Seb-o natchoman", "kæmpeslangegade 21", 112, "massivsnake@anaconda.dk "));
kundeliste.RemoveKunde(10);
kundeliste.Update(4,new Kunde(4, "Oscar","El Dorado 99", 666, "idk@gmail.com"));


Console.WriteLine("\n");
kundeliste.PrintMenu();
Console.WriteLine("\n");

PizzaMenu pizzaMenu = new PizzaMenu();
pizzaMenu.AddPizza(new Pizza(20, "Hawaii", "Tomat, Ost & ananas", 80));
pizzaMenu.Update(20, new Pizza(20, "Oscar special", "mixed kød m. dressing", 100));
pizzaMenu.PrintMenu();

Console.WriteLine("\n");
pizzaMenu.FindPizzaByToppings("Gorgonzola");
Console.WriteLine("\n");

ExtraToppiongsMenu Toppingsmenu = new ExtraToppiongsMenu();
Toppingsmenu.PrintMenu();
Console.WriteLine("\n");

Ordre ordre = new Ordre(1, kundeliste.Kunder[0], 1, pizzaMenu.Pizzas[17], pizzaMenu.Pizzas[17].PizzaPris, "hej mr. alibaba");
ExtraToppings extraToppings = new ExtraToppings(1, Toppingsmenu.Toppings[22].ToppingNavn, Toppingsmenu.Toppings[22].Pris);
Ordrelinje ordrelinje = new Ordrelinje(ordre, kundeliste.Kunder[0], extraToppings);
Console.WriteLine(ordrelinje);

