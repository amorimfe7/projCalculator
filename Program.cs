namespace Calculator{

    class Program{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("=========== BEM VINDO A CALCULADORA ===========");
            Console.WriteLine("");
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short selection = short.Parse(Console.ReadLine());

            switch (selection){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); 
                break;
                        
                default:Console.WriteLine("");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Deseja sair da aplicação?");
                        Console.WriteLine("");
                        Console.WriteLine("[1] - Sim || [2] - Retornar para Menu"); 
                        string option = Console.ReadLine();

                        Fechar(option); break;
            }
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

            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para retornar ao Menu ou [0] - Sair");
            string option = Console.ReadLine();
            Fechar(option);

            Console.ReadKey();
            Menu();
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

            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para retornar ao Menu ou [0] - Sair");
            string option = Console.ReadLine();
            Fechar(option);

            Console.ReadKey();
            Menu();
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

            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para retornar ao Menu ou [0] - Sair");
            string option = Console.ReadLine();
            Fechar(option);

            Console.ReadKey();
            Menu();
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

            Console.WriteLine("");
            Console.WriteLine("Pressione [Enter] para retornar ao Menu ou [0] - Sair");
            string option = Console.ReadLine();
            Fechar(option);

            Console.ReadKey();
            Menu();
        }

        static void Fechar(string option){
            if (option == "0" || option == "1"){
                System.Environment.Exit(0);
            } else{
                Menu();
            }
        }
    }
}

