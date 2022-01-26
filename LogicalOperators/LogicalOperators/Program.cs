// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores logicos");

bool value1 = true;
bool value2 = false;
bool value3 = true;

bool result = value1 && value3;
Console.WriteLine("Conjuncion: &&; verdadero y verdadero es " + result);

result = value2 || value3;
Console.WriteLine("Disyuncion: ||; falso y verdadero es " + result);

result = !value1;
Console.WriteLine("Negacion: !; verdadero negada es " + result);
