using SemFabrica.Entidades;
using SemFabrica.Entidades.Base;
using System;

namespace SemFabrica
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("========== Pizzaria ==========");
      Console.WriteLine("Informe o tipo da pizza (C)alabresa ou (M)ussarela:");

      var tipoPizza = Console.ReadLine().ToUpper();

      Pizza pizza;

      /*
       Observe abaixo que a lógica de instanciação está na classe Cliente (Program.cs)
       que utilizará os Produtos Concretos (PizzaCalabresa e PizzaMussarela) gerando um
       forte acoplamento
       */
      if (tipoPizza == "C")
      {
        pizza = new PizzaCalabresa();
      }

      else if (tipoPizza == "M")
      {
        pizza = new PizzaMussarela();
      }

      else
      {
        Console.WriteLine("A pizza não pode ser criada, pois não foi informado um tipo" +
          "ou o tipo informado é inválido");
        return;
      }

      pizza.Preparar();
      pizza.Assar();
      pizza.Embalar();
      Console.WriteLine("Pizza concluída com sucesso");

    }
  }
}
