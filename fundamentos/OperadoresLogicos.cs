
namespace Fundamentos01;

public class OperadoresLogicos
{


    public void Executar()
    {

        Console.WriteLine("OPERADORES LOGICos");

        bool temidade = true;
        bool temCarta = false;

        Console.WriteLine($"Tem Idade ? {temidade}");
        Console.WriteLine($"Tem Carta ? {temCarta}");
        Console.WriteLine();
        Console.WriteLine($"Pode dirigir? (Tem idade e carta){temidade && temCarta} (AND)");
        Console.WriteLine($"Pode tenter tirar? (Tem idade ou carta){temidade || temCarta} (OR)");
        Console.WriteLine($"Nao tem idade? (!Tem idade){!temidade } (NOT)");




    




    }










}