using System;
using System.Collections.Generic;
using System.Text;

namespace CuentaBancaria
{
    class Cuenta
    {
        //Identificación fiscal de la cuenta bancaria
        int numCuenta;

        //Hace referencia al nombre del cliente
        String nombre;

        //Saldo monetario de la cuenta
        double saldo;

        //Tipo interés aplicado en tanto por ciento
        double tipoInteres;

        public Cuenta()
        {
        }
        public Cuenta(int numeroCuenta, String nombre, double saldo, double tipoInteres)
        {
            this.numCuenta = numeroCuenta;
            this.nombre = nombre;
            this.saldo = saldo;
            this.tipoInteres = tipoInteres;
        }

       public void setNumCuenta(int numCuenta)
        {
            this.numCuenta = numCuenta;
        }
        public int getNumCuenta()
        {
            return numCuenta;
        }

        public void setNombre(String Nombre)
        {
            this.nombre = Nombre;
        }
        public String getNombre()
        {
            return nombre;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return saldo;
        }

        public void setTipoInteres(double interes)
        {
            this.tipoInteres = interes;
        }
        public double getTipoInteres()
        {
            return tipoInteres;
        }

        public void EstadoCuenta()
        {
            Console.WriteLine("***********  ESTADO CUENTA  **********");
            Console.WriteLine("Numero de Cuenta: " + getNumCuenta());
            Console.WriteLine("Nombre: " + getNombre());
            Console.WriteLine("Saldo: " + getSaldo() + "¥");
            Console.WriteLine("Tipo Interes: " + getTipoInteres() + "%");
            Console.WriteLine("**************************************");
        }
        
    }
}
