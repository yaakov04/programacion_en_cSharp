// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ciclo while");

Console.WriteLine("Logic game\n");

Console.WriteLine("adivina el valor de verdad\n");

int gameOn = 1;

while (gameOn == 1)
{
    Console.WriteLine("Quieres comenzar el juego?\n");
    int gameOnTmp = Convert.ToInt32(Console.ReadLine());
    if (gameOnTmp == 1 || gameOnTmp == 0)
    {
        gameOn = gameOnTmp;
        if (gameOn == 1)
        {
            bool P = true;
            bool Q = false;
            bool expresion = P || Q;
            Console.WriteLine("Cual es el valor de verdad de la siguiente expresion?");
            Console.WriteLine("Solo se aceptan las respuestas true o false");
            Console.WriteLine(P + " || " + Q);
            string answerTmp = Console.ReadLine();
            if (answerTmp == "true" || answerTmp == "false")
            {
                bool answer = Convert.ToBoolean(answerTmp);
                if (answer == expresion)
                {
                    Console.WriteLine("Correcto!!!");
                    gameOn = 0;
                }
                else
                {
                    Console.WriteLine("Game over");
                    gameOn = 0;
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida");
                gameOn = 0;
            }
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }
    if (gameOn == 0)
    {
        Console.WriteLine("Adios");
    }
}


