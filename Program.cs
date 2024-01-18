namespace Calculator{

    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();



            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short selection = short.Parse(Console.ReadLine());
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

