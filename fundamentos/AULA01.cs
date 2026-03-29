using System;

namespace Fundamentos01
{
    class AULA01
    {


        public void ExecutarAula()
        {
            
            this.ExibirCabecalho();
            Variaveisetipodedados variaveisetipodedados = new Variaveisetipodedados();
            variaveisetipodedados.Executar();





            this.ResumoAula();


             

        }

 
               private void ExibirCabecalho()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   AULA 01 - FUNDAMENTOS DE ALGORITMIA");
        Console.WriteLine("======================================");
        Console.WriteLine();
    }
 
    private void ResumoAula()
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("   FIM DA AULA - RESUMO");
        Console.WriteLine("======================================");
        Console.WriteLine("✓ O que é algoritmia");
        Console.WriteLine("✓ Variáveis e tipos de dados");
        Console.WriteLine("✓ Operadores aritméticos, comparação e lógicos");
        Console.WriteLine("✓ Estruturas de controle básicas");
    }








            
    }
    
}