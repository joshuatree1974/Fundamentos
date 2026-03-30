
using System.Diagnostics.Tracing;

namespace Fundamentos;


 public class EstruturasControleBasicas
 {


    public void ExecutarIfElse()
    {
        
        Console.WriteLine("Estruturas de Controle basicas\n");
        Console.WriteLine();
      

         // 1  ESTRUTURA IF-ELSE


         int nota = 14;
         Console.WriteLine($"Nota do Aluno: {nota}");
        
        if (nota == 16) 
        {
            Console.WriteLine("Situaçao : APROVADO (IF)");
        

        }

        else
        {

          
          Console.WriteLine("Situaçao : CHUMBADO (else)");  

        }
    

    }



    public void ExecutarSwitchCase()
    {
        int diaDaSemana = 3;
        Console.WriteLine($"Numero do dia da Semana {diaDaSemana}");

        switch (diaDaSemana)
        {
            case 1:
              Console.WriteLine("Dia: Segunda-Feira");
              break;


            case 2:
              Console.WriteLine("Dia: Terça-Feira");
              break;

            case 3:
              Console.WriteLine("Dia: Quarta-Feira");
              break;

            case 4:
              Console.WriteLine("Dia: Quinta-Feira");
              break;
              

            case 5:
              Console.WriteLine("Dia: Sexta-Feira");
              break;

            case 6:
              Console.WriteLine("Dia: Sabado");
              break;

            default:
              Console.WriteLine("Dia: Domingo");
              break;

        }
        





    }
    









 }