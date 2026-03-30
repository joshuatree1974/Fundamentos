
namespace Fundamentos;


 public class Exercicio4comb
 {


    public void Executar()
    {
        bool temEntrada = true;
        bool temConvite = false;
        bool ehVIP = true;

        bool podeEntrar = (temEntrada || temConvite) && ehVIP;

        Console.WriteLine($"Tem entrada? {temEntrada}");
        Console.WriteLine($"Tem convite? {temConvite}");
        Console.WriteLine($"É VIP? {ehVIP}");
        Console.WriteLine($"Pode entrar? (({temEntrada} || {temConvite}) && {ehVIP}) = {podeEntrar}");

        Console.WriteLine();
      

       


    }
    









 }