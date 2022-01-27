// See https://aka.ms/new-console-template for more information
Console.WriteLine("El condicional");

Random rnd = new Random();

int randomValue = rnd.Next(6, 15);
Console.WriteLine("el numero es: "+ randomValue);
string message = "";

if (randomValue == 7)
{
    message = "El valor es 7";
}
else if(randomValue == 14)
{
    message = "El valor es 14";
}
else
{
    message = "El valor no es 7";
}

Console.WriteLine(message);
