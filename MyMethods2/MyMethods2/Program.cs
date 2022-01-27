// See https://aka.ms/new-console-template for more information
Console.WriteLine("Creando metodos 2\n");

void printName (String name)
{
    Console.WriteLine(name);
}

printName("Diego Briones");

Console.WriteLine("\nCalculadora\n");

int sum (int x, int y)
{
    return x + y;
}

int res(int x, int y)
{
    return x - y;
}

int mult(int x, int y)
{
    return x * y;
}

int div(int x, int y)
{
    return x / y;
}

int resultDiv = div(10, 2);
Console.WriteLine("La division es: " + resultDiv);

int resultMult = mult(10, 2);
Console.WriteLine("La multiplicacion es: " + resultMult);

int resultRes = res(10, 2);
Console.WriteLine("La resta es: " + resultRes);

int resultSum = sum(10, 2);
Console.WriteLine("La suma es: " + resultSum);