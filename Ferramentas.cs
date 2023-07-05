using System;

namespace IMCcalculator
{
    public static class Ferramentas
    {
        public static void print(dynamic texto = null)
        {
            if (texto != null) Console.WriteLine(texto);
            else Console.WriteLine();
        }
        public static void print_(dynamic texto)
        {
            Console.Write(texto);
        }
        

        public static void ColorLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void ColorBack(string text, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
