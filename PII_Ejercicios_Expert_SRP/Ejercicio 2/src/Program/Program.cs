using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
//          Almacenador.AlmacenarLibro("A","7", libro1);
//          Almacenador.AlmacenarLibro("B","3", libro2);
//          Console.WriteLine($"Estante: {libro1.EstanteBiblioteca}, Sector: {libro1.SectorBiblioteca}");
//          Console.WriteLine(libro2.EstanteBiblioteca,libro2.EstanteBiblioteca);
            Location A1 = new Location("A","1");
            A1.ArchivarLibro(libro1);
            Console.WriteLine(libro1.Location);
    
        }
    }
}
