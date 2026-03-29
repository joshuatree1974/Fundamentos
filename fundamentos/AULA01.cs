using System;
using Fundamentos;

namespace Fundamentos01
{
    class AULA01
    {


        public void ExecutarAula()
        {
            
            this.ExibirCabecalho();
            Variaveisetipodedados variaveisetipodedados = new Variaveisetipodedados();
            variaveisetipodedados.Executar();
            Console.WriteLine();
            OperadoresAritmeticos operadoresAritmeticos = new OperadoresAritmeticos();
            operadoresAritmeticos.Executar();Console.WriteLine();
            OperadoresComparacao operadoresComparacao = new OperadoresComparacao();
            operadoresComparacao.Executar();
            Console.WriteLine();
            OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
            operadoresLogicos.Executar();
            Console.WriteLine();
            VariaveisBasicas variaveisBasicas = new VariaveisBasicas();
            variaveisBasicas.Executar();
            Console.WriteLine();
            Reatribuicao reatribuicao = new Reatribuicao();
            reatribuicao.Executar();

            



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