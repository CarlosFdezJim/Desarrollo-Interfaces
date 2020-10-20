using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{

    public class Persona
    {
        private String Nombre;
        List<Persona> vector;

        public Persona()
        {
            this.Nombre = "";
        }

        public Persona(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public void DataBase()
        {
            vector = new List<Persona>()
            {
                new Persona("Aurelio"),
                new Persona("Felipe"),
                new Persona("Manolo"),
                new Persona("Carlos"),
                new Persona("Claudia")
            };

            ImprimirTodo();

            //for (int i = 0; i < 5; i++)
            //{
            //    vector[i].Imprimir();
            //}

        }

        public void OrdenarDB()
        {
            var listaPersonasOrdenada = vector.OrderBy(x => x.Nombre).ToList();

            for (int i = 0; i < 5; i++)
            {
                listaPersonasOrdenada[i].Imprimir();
            }

        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("************************************");
        }

        public void ImprimirTodo()
        {
            for (int i = 0; i < 5; i++)
            {
                vector[i].Imprimir();
            }

        }
    }
}
