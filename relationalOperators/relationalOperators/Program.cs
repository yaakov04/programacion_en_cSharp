// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores relacionales");

int num1 = 18;
int num2 = 10;
int num3 = 18;

bool isEqual = num1 == num3;
Console.WriteLine(num1 + " es igual " + num3 + " es " + isEqual);

bool isntEqual = num1 != num2;
Console.WriteLine(num1 + " no es igual " + num2 + " es " + isntEqual);

bool greaterThan = num1 > num3;
Console.WriteLine(num1 + " es mayor que " + num3 + " es " + greaterThan);

bool lessThan = num1 < num2;
Console.WriteLine(num1 + " es menor que " + num2 + " es " + lessThan);

bool greaterThanOrEqual = num1 >= num3;
Console.WriteLine(num1 + " es mayor o igual que " + num3 + " es " + greaterThanOrEqual);

bool lessThanOrEqual = num1 <= num2;
Console.WriteLine(num1 + " es menor o igual que " + num2 + " es " + lessThanOrEqual);


