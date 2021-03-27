using ComFabricaSimples.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComFabricaSimples.Entidades
{
  /*
   
    Subclasses concretas (conceitualmente denominadas ConcretProduct) que são as extensões 
    ou implementações da classe base/interface (AbstractProduct)
   
   */

  public class PizzaCalabresa : Pizza
  {
    public PizzaCalabresa()
    {
      Nome = "Pizza de calabresa";
    }
    public override void Assar()
    {
      Console.WriteLine($"{Nome} assando por minutos");
    }

    public override void Embalar()
    {
      Console.WriteLine($"{Nome} embalada!");
    }

    public override void Preparar()
    {
      Console.WriteLine($"{Nome} preparada com sucesso!");
    }
  }
}
