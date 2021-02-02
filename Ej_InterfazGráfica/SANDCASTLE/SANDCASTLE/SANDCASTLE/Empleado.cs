#region Encabezado de comentarios
// Adaptación de: http://cupi2.uniandes.edu.co/sitio/index.php/cursos/apo1/nivel-1/el-empleado/visualizacion-codigo/empleado
// ===++===
//
//	OrtizOL
//
// ===--===
/*============================================================
//
// Clase: Empleado.cs
//
// Propósito: Representar a la clase de `Empleado` del 
// modelo del mundo del problema.
//
============================================================*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_Empleado.Modelo
{
    /// <summary>
    /// Representa a la clase Empleado del modelo del mundo del problema.
    /// </summary>
    public class Empleado
    {
        #region Campos
        /// <summary>
        /// Nombre del empleado.
        /// </summary>
        private string nombre;

        /// <summary>
        /// Apellido del empleado.
        /// </summary>
        private string apellido;

        /// <summary>
        /// Género (sexo) del empleado.
        /// </summary>
        private char genero;

        /// <summary>
        /// Fotografía del empleado.
        /// </summary>
        private PictureBox foto;

        /// <summary>
        /// Salario del empleado.
        /// </summary>
        private decimal salario;

        /// <summary>
        /// Fecha de nacimiento del empleado.
        /// </summary>
        private Fecha fechaNacimiento;

        /// <summary>
        /// Fecha de ingreso del empleado a la organizaicón.
        /// </summary>
        private Fecha fechaIngreso;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public char Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }

        //public PictureBox Foto
        //{
        //    get
        //    {
        //        return foto;
        //    }
        //    set
        //    {
        //        foto = value;
        //    }
        //}

        public decimal Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }

        //public Fecha FechaNacimiento
        //{
        //    get
        //    {
        //        return fechaNacimiento;
        //    }
        //    set
        //    {
        //        fechaNacimiento = value;
        //    }
        //}

        //public Fecha FechaIngreso
        //{
        //    get
        //    {
        //        return fechaIngreso;
        //    }
        //    set
        //    {
        //        fechaIngreso = value;
        //    }
        //}
        #endregion

        #region Constructores
        /// <summary>
        /// Crea un empleado con los datos básicos.
        /// </summary>
        /// <param name="nombre">Nombre del empleado.</param>
        /// <param name="apellido">Primer apellido dempleado.</param>
        /// <param name="genero">Género (sexo) del empleado.</param>
        public Empleado(string nombre, string apellido, char genero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
        }

        public Empleado()
        {

        }
        /// <summary>
        /// Crea un empleado con todos los datos inicializados.
        /// </summary>
        /// <param name="nombre">Nombre del empleado.</param>
        /// <param name="apellido">Primer apellido dempleado.</param>
        /// <param name="genero">Género (sexo) del empleado.</param>
        /// <param name="salario">Salario del empleado.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del empleado.</param>
        /// <param name="fechaIngreso">Fecha de ingreso del empleado a la compañía.</param>
        /// <param name="imagen">Fotografía del empleado.</param>
        //public Empleado(string nombre, string apellido, char genero, decimal salario, Fecha fechaNacimiento, Fecha fechaIngreso, PictureBox imagen)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.genero = genero;
        //    this.salario = salario;
        //    this.fechaNacimiento = fechaNacimiento;
        //    this.fechaIngreso = fechaIngreso;
        //    foto = imagen;
        //}
        #endregion

        #region Métodos Auxiliare
        /// <summary>
        /// Calcula la edad del empleado con base en la fecha de nacimiento.
        /// </summary>
        /// <returns>Edad del empleado.</returns>
        public int CalcularEdad()
        {
            Fecha fechaActual = new Fecha();

            return fechaNacimiento.CalcularDiferenciaMeses(fechaActual) / 12;
        }

        /// <summary>
        /// Calcula la antigüedad del mpleado. 
        /// </summary>
        /// <returns>Devuelve la antigüedad del empleado hasta la fecha actual.</returns>
        public int CalcularAntiguedad()
        {
            Fecha fechaActual = new Fecha();

            return fechaIngreso.CalcularDiferenciaMeses(fechaActual) / 12;
        }

        /// <summary>
        /// Calcula las prestaciones del empleado.
        /// </summary>
        /// <returns>Prestaciones del empleado.</returns>
        public decimal CalcularPrestaciones()
        {
            return (CalcularAntiguedad() * salario) / 12;
        }
        #endregion

        /// <summary>
        /// Punto de extension (1) del empleado.
        /// (Podría tratarse de un método adicional.)
        /// </summary>
        /// <returns>Cadena de texto con mensaje de prueba.</returns>
        #region Puntos de extensión
        public string Metodo1()
        {
            return "Mensaje de respuesta 1";
        }

        /// Punto de extension (2) del empleado.
        /// (Podría tratarse de un método adicional.)
        /// </summary>
        /// <returns>Cadena de texto con mensaje de prueba.</returns>
        public string Metodo2()
        {
            return "Mensaje de respuesta 2";
        }
        #endregion
    }
}