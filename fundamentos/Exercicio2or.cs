

namespace Fundamentos;


 public class Exercicio2or
 {


    public void Executar()
    {
        

       bool estaLogado = false;
       bool ehAdmin = true;

       bool acessoPermitido = estaLogado || ehAdmin;

       Console.WriteLine($"Está logado? {estaLogado}");
       Console.WriteLine($"É admin? {ehAdmin}");
       Console.WriteLine($"Acesso permitido? ({estaLogado} || {ehAdmin}) = {acessoPermitido}");

       Console.WriteLine();


    }
    









 }