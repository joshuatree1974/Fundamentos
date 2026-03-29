
namespace Fundamentos01;

public class TipoObjet
{

   public void Executar()
   {


    object variavel = "Olá mundo";
    Console.WriteLine($"Valor: {variavel} | Tipo: {variavel.GetType()}");

    variavel = 123;
    Console.WriteLine($"Valor: {variavel} | Tipo: {variavel.GetType()}");

    variavel = true;
    Console.WriteLine($"Valor: {variavel} | Tipo: {variavel.GetType()}");

    Console.WriteLine();
        




   }
    






}