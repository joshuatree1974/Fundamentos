
namespace Fundamentos;


 public class Exercicio1and
 {


    public void Executar()
    {
        

       bool temIdade = true;
       bool temCarta = false;

       bool podeDirigir = temIdade && temCarta;

       Console.WriteLine($"Tem idade? {temIdade}");
       Console.WriteLine($"Tem carta? {temCarta}");
       Console.WriteLine($"Pode dirigir? ({temIdade} && {temCarta}) = {podeDirigir}");

       Console.WriteLine();



    }
    









 }