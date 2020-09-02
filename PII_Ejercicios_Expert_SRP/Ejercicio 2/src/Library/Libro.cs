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



/*  Considero que en estas circunstancias, la clase Libro estaría ocupándose del registro del libro, y además de su almacenamiento en el sector y estante
    que se le asigne. Por lo tanto, ésta clase tendría una responsabilidad divida. En este caso, me parece competente la creación de una nueva clase que
    se ocupe de almacenar al libro en el lugar que corresponda */