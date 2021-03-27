using ComFabricaSimples.Entidades.Base;
using ComFabricaSimples.Fabrica;
using System;

namespace ComFabricaSimples
{
  /*
   
    Classe (conceitualmente denominada Client) que solicitará e utilizará o objeto a ser 
    criado

   */

  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("========== Pizzaria ==========");
      Console.WriteLine("Informe o tipo da pizza (C)alabresa ou (M)ussarela:");

      try
      {
        var pizza = PizzaFabricaSimples.Fabricar(Console.ReadLine());

        /*
         
          Se for necessário criar um novo tipo de pizza, a classe Client (esta aqui) não
          precisará ser modificada
         
         */


        pizza.Preparar();
        pizza.Assar();
        pizza.Embalar();

        Console.WriteLine("Pizza concluída com sucesso");
      }
      catch (ApplicationException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
