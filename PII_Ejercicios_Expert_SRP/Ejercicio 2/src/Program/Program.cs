using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Ubicacion A1 = new Ubicacion("A","1");
            Biblioteca bibliotecaNacional = new Biblioteca();
            bibliotecaNacional.ArchivarLibro(A1, libro1);
            bibliotecaNacional.ArchivarLibro(A1, libro2); 
            Console.WriteLine("===================================");
            A1.MostrarLibros(); 
    
        }
    }
}
