using System;

namespace SRP
{
    public class Libro
    {
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string Location {get;set;}

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }

    public class Location
    {
        public string SectorBiblioteca {get; set;}
        public string EstanteBiblioteca{get; set;}

        public Location (string sectorBiblioteca, string estanteBiblioteca)
        {
            this.SectorBiblioteca = sectorBiblioteca;
            this.EstanteBiblioteca = estanteBiblioteca;                
        }
        public void ArchivarLibro(Libro book)
        {
            book.Location = $"Ubicación del libro {book.Titulo} --> Sector: {this.SectorBiblioteca}  -  Estante: {this.EstanteBiblioteca}";
        }
    }
}
