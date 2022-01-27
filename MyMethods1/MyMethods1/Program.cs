using System;

namespace MyMethods1
{
    internal class MyMethods1
    {
        public void Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("El resultado de la suma es: "+result);
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Creando mis propios metodos\n");

            MyMethods1 myProgram = new MyMethods1();

            myProgram.Sum(1, 2);
            int mult = myProgram.Mult(2, 5);
            Console.WriteLine("\nEl resultado de la multiplicacion es: " + mult);

        }
    }
}
