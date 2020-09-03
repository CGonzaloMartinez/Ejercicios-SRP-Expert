using System;
using System.Collections;


namespace SRP
{
    public class Ubicacion
    {
        public string SectorBiblioteca {get; set;}
        public string EstanteBiblioteca{get; set;}

        public Ubicacion (string sectorBiblioteca, string estanteBiblioteca)
        {
            this.SectorBiblioteca = sectorBiblioteca;
            this.EstanteBiblioteca = estanteBiblioteca;                
        }
        public ArrayList librosContenidos = new ArrayList();

        public void MostrarLibros()
        {
            Console.WriteLine($"Libros que se encuentran en la ubicación {this.SectorBiblioteca}{this.EstanteBiblioteca}:");
            foreach (string nombreLibro in this.librosContenidos)
            {
                Console.WriteLine($"\t{nombreLibro}");
            }
        }
    }
      
}