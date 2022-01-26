// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numbers");

int num_int = 1;

float num_float = 1.1f;

double num_double = 1.11111;

Console.WriteLine(num_int + " es un entero");
Console.WriteLine(num_float + " es un float");
Console.WriteLine(num_double + " es un double");


Console.WriteLine("\nOperadores aritmeticos");

int num1 = 2, num2 = 3;
float num3 = 2.5f, num4 = 1.5f;

//suma
int sum_int = num1 + num2;
Console.WriteLine("suma entre enteros 2 y 3: " + sum_int);

float sum_float = num1 + num3;
Console.WriteLine("suma entre un entero y un float 2 y 2.5: " + sum_float);

//resta
float res_float = num1 - num4;
Console.WriteLine("resta entre un entero y un float 2 y 1.5" + res_float);

//multiplicacion
int mult_int = num1 * num2;
Console.WriteLine("multiplicacion entre 2 y 3: " + mult_int);

//division
float div_int = (float)num1 / (float)num2;
Console.WriteLine("La division entre 2.0 y 3.0: " + div_int);

//incremento y decremento
Console.WriteLine("\nOperadores de incremento << var++ >>");
num1++;
num1++;
num1++;

Console.WriteLine(num1);

Console.WriteLine("\nOperadores de decremento << var-- >>");
num1--;
num1--;

Console.WriteLine(num1);

Console.WriteLine("\nOperador << num += num >>");
Console.WriteLine(num1 += 10);

Console.WriteLine("\nOperador << num -= num >>");
Console.WriteLine(num1 += 1);


