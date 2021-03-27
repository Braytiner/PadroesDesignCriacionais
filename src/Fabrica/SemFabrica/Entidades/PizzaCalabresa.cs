using SemFabrica.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemFabrica.Entidades
{
  class PizzaCalabresa : Pizza
  {
    public PizzaCalabresa()
    {
      Nome = "Pizza de calabresa";
    }

    public override void Assar()
    {
      Console.WriteLine($"{Nome} assando por 30 minutos");
    }

    public override void Embalar()
    {
      Console.WriteLine($"{Nome} embalada!");
    }

    public override void Preparar()
    {
      Console.WriteLine($"{Nome} preparada!");
    }
  }
}
