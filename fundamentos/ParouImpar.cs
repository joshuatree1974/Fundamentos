
namespace Fundamentos;


 public class ParouImpar
 {


    public void Executar()
    {
        
     Console.WriteLine("📝 Exercício 2: Par ou Ímpar (Ternário)");

     Console.Write("Digite um número: ");
     int numero2 = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine($"Número digitado: {numero2}");

     string resultado = (numero2 % 2 == 0) ? "PAR" : "ÍMPAR";

     Console.WriteLine($"O número {numero2} é {resultado}");

     Console.WriteLine();
       



    }
    









 }