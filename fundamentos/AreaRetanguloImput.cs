
namespace Fundamentos;


 public class AreaRetanguloImput
 {


    public void Executar()
    {
        
       Console.Write("Digite a largura: ");
       double larguraInput = double.Parse(Console.ReadLine());

       Console.Write("Digite a altura: ");
       double alturaInput = double.Parse(Console.ReadLine());

       double areaInput = larguraInput * alturaInput;

       Console.WriteLine($"Área: {larguraInput} × {alturaInput} = {areaInput}");

       Console.WriteLine();



    }
    









 }