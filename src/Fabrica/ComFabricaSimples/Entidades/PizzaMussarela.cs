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

  public class PizzaMussarela : Pizza
  {
    public PizzaMussarela()
    {
      Nome = "Pizza de mussarela";
    }
    public override void Assar()
    {
      Console.WriteLine($"{Nome} assando por 10 minutos");
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
