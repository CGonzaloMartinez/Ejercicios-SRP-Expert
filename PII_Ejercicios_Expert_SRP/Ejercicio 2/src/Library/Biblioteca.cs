using System;
using System.Collections;


namespace SRP
{
    public class Biblioteca
    {
        public void ArchivarLibro(Ubicacion ubicacion, Libro book)
        {
            book.Location = $"Ubicación del libro {book.Titulo} --> Sector: {ubicacion.SectorBiblioteca} - Estante: {ubicacion.EstanteBiblioteca}";
            ubicacion.librosContenidos.Add(book.Titulo);
            Console.WriteLine($"El libro {book.Titulo} ha sido archivado correctamente en el Sector: {ubicacion.SectorBiblioteca} - Estante: {ubicacion.EstanteBiblioteca}");
        }
    }

}