// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arreglos \n");

string[] coffeTypes;
float[] coffePrices;

coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "Latte" };
coffePrices = new float[] {1.2f, 1.5f, 5.0f, 5.5f };

coffeTypes[1] = "Lungo";

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(coffeTypes[i] + " coffe $" + coffePrices[i]);
}
