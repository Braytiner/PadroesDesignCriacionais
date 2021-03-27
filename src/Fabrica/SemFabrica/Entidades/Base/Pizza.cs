using System;
using System.Collections.Generic;
using System.Text;

namespace SemFabrica.Entidades.Base
{
  abstract class Pizza
  {
    public string Nome { get; set; }
    public abstract void Preparar();
    public abstract void Assar();
    public abstract void Embalar();
  }
}
