
namespace Fundamentos;


 public class Autenticação
 {


    public void Executar()
    {
        
       Console.WriteLine("📝 Exercício 4: Sistema de Autenticação");

       Console.Write("Username: ");
       string username = Console.ReadLine();

       Console.Write("Password: ");
       string password = Console.ReadLine();

       string userCorreto = "admin";
       string passCorreta = "1234";

       if (username == userCorreto && password == passCorreta)
       {
          Console.WriteLine("✅ ACESSO PERMITIDO");
       }
       else
       {
          Console.WriteLine("❌ ACESSO NEGADO");
       }



    }
    









 }