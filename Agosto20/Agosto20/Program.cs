using Agosto20.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agosto20
{
  class Program
  {
    static void Main(string[] args)
    {
      var entero=20;



      // Libreria
      var libro1 =new Libro();
      libro1.Titulo="Harry Potter";
      libro1.Precio=200;
      libro1.Autor ="Autora";

      var libro2 = new Libro("Harry",200,"Autora");

      var libro3 = new Libro()
      {
        Titulo = "Harry Potter",
        Precio = 200,
        Autor = "Autora"
      };

      var booleano=true;

      // arreglo (finito)
      Libro[] libros=new Libro[3];

      libros[0]=libro1;
      libros[1]=libro2;
      libros[2]=libro3;


      int[] numeros=new int[3];

      // diamante < >
      // Clase lista se llama generics
      var listaLibros =new List<Libro>();
      listaLibros.Add(libro1);
      listaLibros.Add(libro2);





    }
  }
}
