using System;
using System.Collections.Generic;
using System.Text;

namespace ComFabricaSimples.Entidades.Base
{
  /*
   
    Classe base abstrata ou interface (conceitualmente denominada AbstractProduct) que 
    representa os modelos dos produtos a serem criados
   
   */

  public abstract class Pizza
  {
    public string Nome { get; set; }
    public abstract void Preparar();
    public abstract void Assar();
    public abstract void Embalar();
  }
}
