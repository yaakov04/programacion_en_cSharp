// See https://aka.ms/new-console-template for more information
Console.WriteLine("Listas");

List<string> tacosShoppingList = new List<string>();

tacosShoppingList.Add("Cinco tacos de suadero");
tacosShoppingList.Add("Cuatro tacos de tripa");
tacosShoppingList.Add("Cinco tacos de pastor");
tacosShoppingList.Add("Cuatro Coca Colas");

for(int i = 0; i < tacosShoppingList.Count; i++)
{
    Console.WriteLine(tacosShoppingList[i]);
}

Console.WriteLine("\nEliminando un elemento");

tacosShoppingList.Remove("Cinco tacos de suadero");

for (int i = 0; i < tacosShoppingList.Count; i++)
{
    Console.WriteLine(tacosShoppingList[i]);
}

Console.WriteLine("\nEliminando un elemento");

tacosShoppingList.RemoveAt(1);

for (int i = 0; i < tacosShoppingList.Count; i++)
{
    Console.WriteLine(tacosShoppingList[i]);
}
