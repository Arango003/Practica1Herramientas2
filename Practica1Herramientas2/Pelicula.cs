using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Herramientas2
{
    internal class Pelicula
    {
        int año;
        string titulo, idioma, productora, director, genero, duracion;

        public Pelicula() { }
        public int Año { get => año; set => año = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Productora { get => productora; set => productora = value; }
        public string Director { get => director; set => director = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
