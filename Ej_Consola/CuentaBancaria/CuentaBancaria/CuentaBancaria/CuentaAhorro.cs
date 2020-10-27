using System;
using System.Collections.Generic;
using System.Text;

namespace CuentaBancaria
{
    class CuentaAhorro:Cuenta
    {
        double cuotaMantenimiento;

        public CuentaAhorro()
        {
        }

        public CuentaAhorro(double cuota)
        {
            this.cuotaMantenimiento = cuota;
        }

        public void setcuotaMantenimiento(double mantenimiento)
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public double getcuotaMantenimiento()
        {
            return cuotaMantenimiento;
        }
        public void EstadoCuenta()
        {
            Console.WriteLine("***********  ESTADO CUENTA  **********");
            Console.WriteLine("Numero de Cuenta: " + getNumCuenta());
            Console.WriteLine("Nombre: " + getNombre());
            Console.WriteLine("Saldo: " + getSaldo() + "¥");
            Console.WriteLine("Tipo Interes: " + getTipoInteres() + "%");
            Console.WriteLine("Cuota de mantenimiento : " + getcuotaMantenimiento() + "%");
            Console.WriteLine("**************************************");
        }
        
    }
}
