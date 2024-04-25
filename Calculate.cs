using System;
using static Biblioteca.Ferramentas;

namespace IMC
{
    static class Calculate
    {
        static void Main()
        {
            string nome;
            float altura, peso, imc;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            ColorLine($"Vamos calcular o seu índice de massa corporal\n\n\n", ConsoleColor.White);
            print_("Digite seu Nome: ");
            var entrada = Console.ReadLine();
            nome = entrada.Substring(0, 1).ToUpper() + entrada.Substring(1).ToLower();

            print_("\nDigite o seu peso: ");
            peso = float.Parse(Console.ReadLine());

            print_("\nDigite sua altura: ");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out _))
            {
                altura = float.Parse(entrada) / 100;
            }
            else if (float.TryParse(entrada, out altura))
            {
                altura = float.Parse(entrada);
            }
            print("\n\n\n");

            imc = peso / (altura * altura);
            imc = (float)Math.Round(imc, 1);

            string espaço = new(' ', 7);
            string space2x = new(' ', 15);
            string space3x = new(' ', 21);
            Console.ForegroundColor = ConsoleColor.White;
            ColorBack($"{space3x}IMC Classificações{space3x}\n\n", ConsoleColor.DarkGray);

            if (imc < 18.5) { ColorLine($"{espaço}Menor do que 18,5 {espaço} Magreza\n", ConsoleColor.Red); }
            else { print($"{espaço}Menor do que 18,5 {espaço} Magreza"); }

            if (imc >= 18.5 && imc <= 24.9) { ColorLine($"{espaço}18,5 - 24,9{space2x}Peso normal\n", ConsoleColor.Green); }
            else { print($"{espaço}18,5 - 24,9{space2x}Peso normal"); }

            if (imc >= 25.0 && imc <= 29.9) { ColorLine($"{espaço}25,0 - 29,9{space2x}Sobrepeso\n", ConsoleColor.Red); }
            else { print($"{espaço}25,0 - 29,9{space2x}Sobrepeso"); }

            if (imc >= 30.0 && imc <= 34.9) { ColorLine($"{espaço}30,0 - 34,9{space2x}Obesidade grau I\n", ConsoleColor.Red); }
            else { print($"{espaço}30,0 - 34,9{space2x}Obesidade grau I"); }

            if (imc >= 35.0 && imc <= 39.9) { ColorLine($"{espaço}35,0 - 39,9{space2x}Obesidade grau II\n", ConsoleColor.Red); }
            else { print($"{espaço}35,0 - 39,9{space2x}Obesidade grau II"); }

            if (imc >= 40.0) { ColorLine($"{espaço}Maior ou igual a 40,0     Obesidade grau III\n", ConsoleColor.Red); }
            else { print($"{espaço}Maior ou igual a 40,0     Obesidade grau III\n"); }

            Console.ForegroundColor = ConsoleColor.White;
            ColorBack($"{espaço} Classificação segundo a OMS a partir do IMC. {espaço}\n\n\n", ConsoleColor.DarkGray);


            print_($"{nome}, o seu IMC é {imc} e é considerado ");
            if (imc < 18.5) { ColorLine("Magreza", ConsoleColor.Red); }
            if (imc >= 18.5 && imc <= 24.9) { ColorLine("Peso normal", ConsoleColor.Green); }
            if (imc >= 25.0 && imc <= 29.9) { ColorLine("Sobrepeso", ConsoleColor.Red); }
            if (imc >= 30.0 && imc <= 34.9) { ColorLine("Obesidade grau I", ConsoleColor.Red); }
            if (imc >= 35.0 && imc <= 39.9) { ColorLine("Obesidade grau II", ConsoleColor.Red); }
            if (imc >= 40.0) { ColorLine("Obesidade grau III", ConsoleColor.Red); }

            if (imc >= 18.5 && imc <= 24.9)
            {
                print(", parabéns :), manter o IMC dentro do Normal ajuda a evitar o aparecimento de várias doenças crônicas, como diabetes e hipertensão.");
            }
            else
            {
                print(", lembrando que, ter um IMC dentro do Normal ajuda a evitar o aparecimento de várias doenças crônicas, como diabetes e hipertensão.");
            }
            print($"\n\n{new string('_', 90)}");

            Console.ReadKey();           

        }
    }
}
