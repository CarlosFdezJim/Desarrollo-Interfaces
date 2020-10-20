using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicio_10
{
    public class Persona
    {
        private String nombre;
        private int edad;
        private String pais;
        Persona[] vectorPersonas;

        public Persona()
        {
            nombre = "";
            edad = 0;
            pais = "";
        }

        public Persona(String Nombre, int Edad, String Pais)
        {
            this.nombre = Nombre;
            this.edad = Edad;
            this.pais = Pais;
        }

        public String getNombre()
        {
            return nombre;
        }


        public void DataBase()
        {
            vectorPersonas = new Persona[5];

            Persona p1 = new Persona("Antonio Kroos", 30, "Alemania");
            vectorPersonas[0] = p1;
            Persona p2 = new Persona("Jadon Sancho", 21, "Inglaterra");
            vectorPersonas[1] = p2;
            Persona p3 = new Persona("David Alaba", 29, "Austria");
            vectorPersonas[2] = p3;
            Persona p4 = new Persona("Cristiano Ronaldo", 33, "Portugal");
            vectorPersonas[3] = p4;
            Persona p5 = new Persona("Francisco Alarcón", 29, "España");
            vectorPersonas[4] = p5;



        }

        public void Menu()
        {
            Console.WriteLine("Bienvenido, selecciona una opción: ");
            Console.WriteLine("");
            Console.WriteLine("************************************");
            Console.WriteLine("1 - Mostrar por nombre");
            Console.WriteLine("2 - Mostrar por edad");
            Console.WriteLine("3 - Mostrar por selección");
            Console.WriteLine("4 - Mostrar todo");
            Console.WriteLine("5 - Salir");
            Console.WriteLine("************************************");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    BuscarUsuarioNombre();
                    break;
                case 2:
                    BuscarUsuarioEdad();
                    break;
                case 3:
                    BuscarUsuarioPais();
                    break;
                case 4:
                    ImprimirTodo();
                    break;
                case 5:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("La opción indicada no es correcta");
                    break;
            }

        }
        public void Imprime()
        {
            Console.WriteLine("Nombre: " + this.nombre + " - Edad: " + this.edad.ToString() + " años, procedente de " + this.pais + ".");
            Console.WriteLine("************************************");
        }

        public void ImprimeNombre()
        {
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("************************************");
        }

        public void ImprimeEdad()
        {
            Console.WriteLine("Edad: " + this.edad.ToString() + " años.");
            Console.WriteLine("************************************");
        }

        public void ImprimePais()
        {
            Console.WriteLine("Procedente de: " + this.pais);
            Console.WriteLine("************************************");
        }

        public void ImprimirTodo()
        {
            for (int i = 0; i < 5; i++)
            {
                vectorPersonas[i].Imprime();
            }

        }

        public void BuscarUsuarioNombre()
        {
            for (int i = 0; i < 5; i++)
            {
                vectorPersonas[i].ImprimeNombre();
            }

        }

        public void BuscarUsuarioEdad()
        {
            for (int i = 0; i < 5; i++)
            {
                vectorPersonas[i].ImprimeEdad();
            }

        }

        public void BuscarUsuarioPais()
        {
            for (int i = 0; i < 5; i++)
            {
                vectorPersonas[i].ImprimePais();
            }

        }
    }
}

