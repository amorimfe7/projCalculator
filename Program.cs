namespace Calculator{

    class Program{
        static void Main(string[] args){
            Subtracao();
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
    }
}

