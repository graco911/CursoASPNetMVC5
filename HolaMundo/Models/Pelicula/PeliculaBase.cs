using System;

namespace HolaMundo.Models.Pelicula
{
    public abstract class PeliculaBase
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Publicacion { get; set; }
        public string Pais { get; set; }
    }
}