
namespace Fundamentos;


 public class DiasdaSemana
 {





    public void Executar()
    {
        
        Console.WriteLine("📝 Exercício 3: Dias da semana (Switch)");

        Console.Write("Digite um número de 1 a 7: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Número digitado: {dia}");

        switch (dia)
        {
          case 1:
          Console.WriteLine("Dia da semana: Segunda-feira");
          break;

          case 2:
          Console.WriteLine("Dia da semana: Terça-feira");
          break;

          case 3:
          Console.WriteLine("Dia da semana: Quarta-feira");
          break;

          case 4:
          Console.WriteLine("Dia da semana: Quinta-feira");
          break;

          case 5:
          Console.WriteLine("Dia da semana: Sexta-feira");
          break;

          case 6:
          Console.WriteLine("Dia da semana: Sábado");
          break;

          case 7:
          Console.WriteLine("Dia da semana: Domingo");
          break;

          default:
          Console.WriteLine("Número inválido!");
          break;
        }

        Console.WriteLine();

       
       



    }
    
}








    









 