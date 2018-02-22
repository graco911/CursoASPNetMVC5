using HolaMundo.Models.Pelicula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Services
{
    public static class Pelicula
    {
        public static List<PeliculaData> List()
        {
            var peliculas = new List<PeliculaData>()
            {
                new PeliculaData{
                    Duracion = 190,
                    Pais = "EU",
                    Publicacion = new DateTime(2010,8,10),
                    Titulo = "Iron Man"
                },
                new PeliculaData{
                    Duracion = 190,
                    Pais = "EU",
                    Publicacion = new DateTime(2011,6,9),
                    Titulo = "Iron Man 2 "
                },
                new PeliculaData{
                    Duracion = 190,
                    Pais = "EU",
                    Publicacion = new DateTime(2012,8,1),
                    Titulo = "Iron Man 3"
                },
                new PeliculaData{
                    Duracion = 190,
                    Pais = "EU",
                    Publicacion = new DateTime(2014,2,25),
                    Titulo = "Civil War "
                },
                new PeliculaData{
                    Duracion = 190,
                    Pais = "EU",
                    Publicacion = new DateTime(2015,10,17),
                    Titulo = "Avengers"
                }
            };

            return peliculas;
        }
    }
}