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

      // tipos de variables
      // primitivas
      int primitiva=20;
      // objetos
      Libro objeto=new Libro();
      // arreglos (finitos)
      // listas hash, stack, queue
      List<string> paises=new List<string>();
      paises.Add("Chile");
      paises.Add("Argentina");
      paises.Add("Peru");

      int contador=0;

      //contador=contador+1;
      //contador++;
      //contador+=1;


      // loop
      // 1) for

      for(int i=0;i<3;i++)
      {
        Debug.WriteLine(paises[i]);
      }

      for (int i = 2; i >= 0; i--)
      {
        Debug.WriteLine(paises[i]);
      }

      // de dos en dos
      for (int i = 0; i < 3; i+=2)
      {
        Debug.WriteLine(paises[i]);
      }


      // ciclo anidado
      for(int i=0;i<10;i++)
      {
        for(int e=0;e<10;e++)
        {
          Debug.WriteLine(i+" "+e);
        }
      }

      // 2) ciclo while
      // quiero usar el while cuando no
      // se cuando debo terminar el loop.
      // Por ejemplo: si voy a leer un texto linea
      // a linea.
      int cont=0;

      while(cont<10)
      {
        Debug.WriteLine("ciclo while");
        cont=cont+1;
      }

      do
      {
        Debug.WriteLine("ciclo while");
        cont = cont + 1;

      } while (cont < 10);

      // 3) foreach
      // necesitamos una lista o arreglo.

      foreach(string pais in paises)
      {
        Debug.WriteLine(pais);
      }

      List<int> precios=new List<int>();
      precios.Add(1);
      precios.Add(2);
      precios.Add(10);

      // obtener el promedio.
      int total=0;
      foreach(int precio in precios)
      {
        total=total+precio;
      }
      int promedio=total/ precios.Count;
      Debug.WriteLine(promedio);

      // alias => alias

      double promedio2=precios.Average(p => p);
      total=precios.Sum(p => p);


    }
  }
}
