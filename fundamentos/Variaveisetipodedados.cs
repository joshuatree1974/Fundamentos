
namespace Fundamentos01;

public class Variaveisetipodedados
{

     public string sobreNome = "Silva";


    
    
    public void Executar()
    {



         Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();

          int idade = 25;
          double altura = 1.75;
          float media = 1950;
          char letra = 'A';
          string nome = "Tony";
          string nomeComposto = nome + "filho";
          bool estudante = true;


        Console.WriteLine($"int - > idade: {idade} (numeros inteiros)");
        Console.WriteLine($"double - > altura: {altura} (numeros decimais)");
        Console.WriteLine($"char - > altura: {letra} (um unico carater)");
        Console.WriteLine($"string - > nome: {nomeComposto} (texto)");
        Console.WriteLine($"variavel global - > sobreNome: {this.sobreNome} (Variavel Global)");
        Console.WriteLine($"bool - > estudante: {estudante} (boleano ou seja verdadeiro ou falso)");




        




    }




}