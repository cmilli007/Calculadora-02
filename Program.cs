﻿double numero1 = 0;

double numero2 = 0;

double resultado = 0;

string operacao;

string sair;

 

do

{
ExibeMenu();


ExibeOpcoes();
    resultado = ExecutaOperacao(operacao, numero1, numero2);

 

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("{0}", resultado);

 

    Console.ForegroundColor = ConsoleColor.Cyan;

    Console.WriteLine("Deseja sair? S/N: ");

    Console.WriteLine();

    Console.ResetColor();

    sair = Console.ReadLine().ToUpper();

}

while (sair != "S" && sair != "SIM");

{

    Console.WriteLine();

    Console.WriteLine("\nVolte sempre!");

}

 

void ExibeOpcoes()

{

    Console.WriteLine();

    Console.WriteLine("Aguarde...");

    Console.WriteLine();

 

    numero1 = SolicitaNumero("primeiro");

 

    Console.WriteLine("Escolha uma operação: ");

    Console.ForegroundColor = ConsoleColor.Green;

    Console.ResetColor();

    operacao = Console.ReadLine();

 

    numero2 = SolicitaNumero("segundo");

    Console.WriteLine();

}

 

void ExibeMenu()

{

    Console.ForegroundColor = ConsoleColor.Green;

 

    Console.WriteLine("+---------------------------+");

    Console.WriteLine("|       Seja-bem vindo      |");

    Console.WriteLine("+---------------------------+");

    Console.WriteLine("|   Comandos das operações: |");

    Console.WriteLine("+---------------------------+");

    Console.WriteLine("|          Soma (+)         |");

    Console.WriteLine("|        Subtração (-)      |");

    Console.WriteLine("|      Multiplicação (*)    |");

    Console.WriteLine("|         Divisão (/)       |");

    Console.WriteLine("|      Exponeciação (^)     |");

    Console.WriteLine("|      Radiação (R ou r)    |");

    Console.WriteLine("+---------------------------+");

 

    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("+--------------------------------------------------------------------------------+");

    Console.WriteLine("|   Observação: a cada etapa, leia as orientações e tecle ENTER para continuar.  |");

    Console.WriteLine("|na radiação (raiz quadrada), o número que irá contar é o primeiro valor digitado|");

    Console.WriteLine("+--------------------------------------------------------------------------------+");

    Console.ResetColor();

}

 

double SolicitaNumero(string ordemNumero)

{

    double numero = 0;

 

    Console.Write("Digite o ");

 

    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write(ordemNumero);

    Console.ResetColor();

 

    Console.WriteLine(" número");

 

    numero = Convert.ToDouble(Console.ReadLine());

 

    return numero;

}

 

double Soma(double numero01, double numero02)

{

    return numero01 + numero02;

}

 

double Subtracao(double numero01, double numero02)

{

    return numero01 - numero02;

}

 

double Divisao(double dividendo, double divisor)

{

    return dividendo / divisor;

}

 

double Multiplicacao(double numero01, double numero02)

{

    return numero01 * numero02;

}

 

double Exponenciacao(double numero01, double numero02)

{

    double Exponenciacao = Math.Pow(numero01, numero02);

    return Exponenciacao;

}

 

double RaizQuadrada(double numero01, double numero02)

{

    double RaizQuadrada = Math.Sqrt(numero01);

    return RaizQuadrada;

}

 

double ExecutaOperacao(string operacao, double numero01, double numero02)

{

    double resultado = 0;

    switch (operacao)

    {

        case "+":

            resultado = Soma(numero01, numero02);

            Console.Write("O valor da soma é: ");

            break;

        case "-":

            resultado = Subtracao(numero01, numero02);

            Console.Write("O valor da subtração é: ");

            break;

        case "/":

            resultado = Divisao(numero01, numero02);

            Console.Write("O valor da divisão é: ");

            break;

        case "*":

            resultado = Multiplicacao(numero01,numero02);

            Console.Write("O valor da multiplicação é: ");

            break;

        case "^":

            resultado = Exponenciacao(numero01,numero02);

            Console.Write("O valor da exponeciação é: ");

            break;

        case "R":

            resultado = RaizQuadrada(numero01,numero02);

            Console.WriteLine($"A raiz quadrada de {numero01} é: ");

            break;

        case "r":

            resultado = RaizQuadrada(numero01,numero02);

            Console.WriteLine($"A raiz quadrada de {numero01} é: ");

            break;

 

        default:

            Console.WriteLine("Operação incorreta!");

            break;

    }

    return resultado;

}