using ComFabricaSimples.Entidades;
using ComFabricaSimples.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComFabricaSimples.Fabrica
{
  /*
     Classe fábrica (conceitualmente denominada Factory) que retorna instancias das classes
     dos produtos (ConcreteProduct => AbstractProduct) através dos seus métodos
  */
  
  class PizzaFabricaSimples
  {
    /*
     
      Na Simple Factory só existe a classe concreta da factory, e é nessa classe onde a 
      lógica de negócio para escolher que Produto instanciar reside.
     
     */
    
    public static Pizza Fabricar(string tipoPizza)
    {
      Pizza pizza;

      tipoPizza = tipoPizza.ToUpper();

      switch (tipoPizza)
      {
        case "C":
          pizza = new PizzaCalabresa();
          break;

        case "M":
          pizza = new PizzaMussarela();
          break;

        default:
          throw new ApplicationException("Tipo inválido de pizza: " + tipoPizza);
      }

      return pizza;
    }
  }
}
