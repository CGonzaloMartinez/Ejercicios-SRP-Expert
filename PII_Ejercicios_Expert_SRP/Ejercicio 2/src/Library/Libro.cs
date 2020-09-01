using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }


    public class Almacenamiento
    {
        public static void AlmacenarLibro(String sector, String estante)
        {
            Libro.SectorBiblioteca = sector;
            Libro.EstanteBiblioteca = estante;

        }

    }
}

// AlmacenarLibro debería ser una clase aparte, pues de esta manera, la clase Libro se está ocupando del registro del libro, 
// y además del almacenamiento en una biblioteca