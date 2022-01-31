using static System.Console;

namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void PressEnter()
        {
            Console.WriteLine("Presione ENTER para continuar");
        }
        public static void DrawLine(int length = 10)
        {
            string line = "".PadLeft(length, '=');
            WriteLine(line);
        }

        public static void writeTitle(string title)
        {
            int lineLength = title.Length + 4;
            DrawLine(lineLength);
            WriteLine($"| {title} |");
            DrawLine(lineLength);
        }
    }
}
