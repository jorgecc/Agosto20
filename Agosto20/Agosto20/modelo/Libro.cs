using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto20.modelo
{
  class Libro
  {
    // Clases, Funciones, Propiedades, Interface
    // propiedades
    public string Titulo { set; get;}
    public int Precio { set; get;}
    public string Autor { set; get;}

    public Libro(string titulo, int precio, string autor)
    {
      Titulo = titulo;
      Precio = precio;
      Autor = autor;
    }

    public Libro()
    {
    }
  }
}
