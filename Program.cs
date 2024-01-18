namespace Calculator{

    class Program{
        static void Main(string[] args){
            Multiplicacao();
        }

        static void Soma(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double resultSum = (v1 + v2);
            Console.WriteLine($"O resultado da soma é {resultSum}");

            Console.ReadKey(); //permaneça na app
        }

        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            double resultSubtraction = (v1 - v2);
            Console.WriteLine($"O resultado da subtração é {resultSubtraction}");

            Console.ReadKey();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultDivision = (v1/v2);
            Console.WriteLine($"O resultado da Divisão é {resultDivision}");

            Console.ReadKey();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultMultiplication = (v1*v2);
            Console.WriteLine($"O resultado da Multiplicação é {resultMultiplication}");

            Console.ReadKey();
        }
    }
}

