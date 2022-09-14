using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Herramientas2
{
    internal class Catalogo
    {
        List<Pelicula> peliculas = new List<Pelicula>();


        public int ValidarPelicula(string nombrePelicula)
        {
            int index = this.peliculas.FindIndex(pelicula => pelicula.Titulo == nombrePelicula);

            return index;
        }

        public void AgregarPelicula()
        {
            int año, posicion;
            string titulo, idioma, productora, director, genero, duracion;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidarPelicula(titulo);
            if (posicion == -1)
            {
                Console.WriteLine("Ingrese el idioma");
                idioma = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de la productora");
                productora = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del director");
                director = Console.ReadLine();
                Console.WriteLine("Ingrese el genero de la pelicula");
                genero = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion de la pelicula");
                duracion = Console.ReadLine();
                Console.WriteLine("Ingrese el año de lanzamiento de la pelicula");
                año = int.Parse(Console.ReadLine());

                this.peliculas.Add(new Pelicula()
                {
                    Titulo = titulo,
                    Idioma = idioma,
                    Productora = productora,
                    Director = director,
                    Genero = genero,
                    Duracion = duracion
                });
            } else
            {
                Console.WriteLine("La pelicula ya existe");
            }

        }

        public void ActualizarPelicula()
        {
            int año, posicion;
            string titulo, idioma, productora, director, genero, duracion;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidarPelicula(titulo);

            if (posicion == -1)
            {
                Console.WriteLine("Esta pelicula no existe en el catalogo");
            } else
            {
                this.peliculas[posicion] = new Pelicula()
                {
                    Titulo=titulo,

                }
            }
        }
    }
}
