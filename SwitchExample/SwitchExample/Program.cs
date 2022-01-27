// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch");

List<string> sodaList = new List<string>
{
    "Coca - Cola",
    "Sprite",
    "Dr. Pepper",
    "Pepsi",
    "Joya de manzana"
};

for (int i = 0; i < sodaList.Count; i++)
{
    Console.WriteLine(i + " - " + sodaList[i]);
}

Console.WriteLine("Enter the selected soda: ");
int selectedSoda = Convert.ToInt32(Console.ReadLine());

switch (selectedSoda)
{
    case 0:
        Console.WriteLine(sodaList[0] + " - 2 USD");
        break;
    case 1:
        Console.WriteLine(sodaList[1] + " - 1 USD");
        break;
    case 2:
        Console.WriteLine(sodaList[2] + " - 1.5 USD");
        break;
    case 3:
        Console.WriteLine(sodaList[1] + " - 1.99 USD");
        break;
    case 4:
        Console.WriteLine(sodaList[1] + " - 1.5 USD");
        break;
    default:
        Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
        break;
}