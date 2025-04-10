using System.Text.RegularExpressions;

namespace ExerciciosRocketseat;

public static class Exercicios
{
    public static void Exercicio01()
    {

        //Ler input e imprimir nome
        Console.Clear();
        Console.WriteLine("Exercicio 01");

        Regex regex = new Regex(@"^[a-zA-z]+$");

        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }

        Console.WriteLine("\nDigite Seu Nome:");
        string input = Console.ReadLine().Trim();
        while (!regex.IsMatch(input))
        {
            Console.Clear();
            Console.WriteLine("Digite Apenas Letras.");
            input = Console.ReadLine().Trim();
        }
        Console.WriteLine("Olá, {0}! Seja Bem-Vindo!", input);
        Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
        Console.ReadKey();
    }
    public static void Exercicio02()
    {
        //Ler 2 inputs e imprimir nome completo
        Console.Clear();
        Console.WriteLine("Exercicio 02");

        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }

        Regex regex = new Regex(@"^[a-zA-z]+$");

        Console.WriteLine("\nDigite Seu Primeiro nome:");
        string input = Console.ReadLine().Trim();
        while (!regex.IsMatch(input))
        {
            Console.Clear();
            Console.WriteLine("Digite Apenas Letras.");
            input = Console.ReadLine().Trim();
        }
        string nome1 = input.Trim();
        Console.WriteLine("Digite Seu Sobrenome:");
        input = Console.ReadLine().Trim();
        while (!regex.IsMatch(input))
        {
            Console.Clear();
            Console.WriteLine("Digite Apenas Letras.");
            input = Console.ReadLine().Trim();
        }

        string nome2 = " " + input.Trim();

        string nomeCompleto = string.Concat(nome1, nome2);
        Console.WriteLine($"Seu Nome Completo: {nomeCompleto}");
        Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
        Console.ReadKey();

    }

    public static void Exercicio03()
    {
        //Ler 2 inputs(double) e imprimir operacoes matematicas
        Console.Clear();
        Console.WriteLine("Exercicio 03");

        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }

        Console.WriteLine("\nDigite Um Valor:");
        string input = Console.ReadLine();
        bool convertido = (double.TryParse(input, out double numero1));
        while (convertido == false)
        {
            Console.Clear();
            Console.WriteLine("O valor digitado não é um numero. Digite um numero Valido:");
            convertido = (double.TryParse(input, out numero1));
        }

        Console.WriteLine("Digite Um Segundo Valor:");
        input = Console.ReadLine();

        convertido = (double.TryParse(input, out double numero2));
        while (convertido == false)
        {
            Console.Clear();
            Console.WriteLine("O valor digitado não é um numero. Digite um numero Valido:");
            convertido = (double.TryParse(input, out numero2));
        }

        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }

        Console.WriteLine($"\nA soma dos numeros é: {numero1 + numero2}");

        Console.WriteLine($"A subtração dos numeros é: {numero1 - numero2}");

        Console.WriteLine($"A muiltiplicação dos numeros é: {numero1 * numero2}");

        Console.WriteLine($"A soma dos numeros é: {numero1 + numero2}");

        Console.WriteLine(numero2 == 0
            ? "Náo é possivel dividir por 0."
            : $"A divisão do Valor {numero1} pelo {numero2} é: {numero1 / numero2}");

        Console.WriteLine($"A media dos dois numeros é: {(numero1 + numero2) / 2}");
        Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
        Console.ReadKey();
    }

    public static void Exercicio04()
    {
        Console.Clear();
        Console.WriteLine("Exercicio 04");
        //usuario vai digitar palavras ou textos e sera imprimido o numero de caracteres
        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }

        Console.WriteLine("\nDigite Oque Quiser:");
        string input = Console.ReadLine().Trim();
        Console.WriteLine($"A quantidade de caracteres digitados foi: {input.Length}");
        Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
        Console.ReadKey();
    }

    public static void Exercicio05()
    {
        Regex regex = new Regex(@"^[A-Za-z0-9]+$");
        Regex validNum = new Regex(@"^[0-9]+$");
        Regex validLetra = new Regex(@"^[A-Za-z]+$");

        Console.Clear();
        Console.WriteLine("Exercicio 05");
        //usuario vai digitar placa de carro e sera verificado se esta valido ou nao (XXX-1234)
        //pos revisao descobri que seria mais facil usar o substring e configurar de maneira mais efetiva o regex.
        for (int i = 0; i < 100; i++)
        {
            Console.Write('-');
        }
        string letras = "";
        string numeros = "";

        Console.WriteLine("\nInsira a Placa Do Carro (Letras e numeros).");
        string input = Console.ReadLine().Trim();
        while (!regex.IsMatch(input) || input.Length > 7)
        {
            Console.WriteLine("Você digitou Simbolos ou Excedeu 7 Caracteres.\n Digite Novamente!");
            input = Console.ReadLine().Trim();
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (i < 3)
            {
                letras += input[i].ToString();
            }
            else
            {
                numeros += input[i].ToString();
            }
        }
        Console.WriteLine(validLetra.IsMatch(letras) & validNum.IsMatch(numeros) ? "A placa esta de acordo com o formato valido" : "A placa esta fora do formato");
        Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
        Console.ReadKey();


    }

    public static void Exercicio06()
    {
        
        bool finalizar = false;
        while (!finalizar) {
            Console.Clear();
            Console.WriteLine("Exercicio 06");
            //usuario vai digitar um valor que ira definir o tipo de data a ser exibido
            for (int i = 0; i < 100; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine("\nEscolha em qual formato exibir a Data:");
            Console.WriteLine("(1) Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
            Console.WriteLine("(2) Apenas a data no formato \"01/03/2024\"");
            Console.WriteLine("(3) Apenas a hora no formato de 24 horas.");
            Console.WriteLine("(4) A data com o mês por extenso.");
            Console.WriteLine("(5) Sair.");

            int input = int.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    DateTime data = DateTime.Now;
                    Console.WriteLine("Data Completa: {0}", data.ToString("F"));
                    Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
                    Console.ReadKey();
                    break;

                case 2:
                    data = DateTime.Now;
                    Console.WriteLine("Data Abreviada: {0}", data.ToString("d"));
                    Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
                    Console.ReadKey();
                    break;

                case 3:
                    data = DateTime.Now;
                    Console.WriteLine("Horario Atual: {0}", data.ToString("HH:mm:ss"));
                    Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
                    Console.ReadKey();
                    break;

                case 4:
                    data = DateTime.Now;
                    Console.WriteLine("Data mes: {0}", data.ToString("dd/MMMM/yyyy"));
                    Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
                    Console.ReadKey();
                    break;

                case 5:
                    finalizar = true;
                    break;

                default:
                    Console.WriteLine("Valor Digitado Invalido!");
                    Console.WriteLine("Aperte Qualquer Tecla para Prosseguir.");
                    Console.ReadKey();
                    break;
            }
        }
        


            



    }
}         