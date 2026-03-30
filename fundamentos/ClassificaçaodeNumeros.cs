
namespace Fundamentos;


 public class ClassificaçaodeNumeros
 {


    public void Executar()
    {
        
        Console.WriteLine("📝 Exercício 1: Classificação de números");

        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Número digitado: {numero}");

        if (numero > 0)
         {
            Console.WriteLine("O número é POSITIVO");
         }
        else if (numero < 0)
         {
           Console.WriteLine("O número é NEGATIVO");
         }
        else
         {
              Console.WriteLine("O número é ZERO");
         }

             Console.WriteLine();

       



    }
    









 }
