using System;

namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************************************************//
            Cuenta c = new Cuenta();

            c.setNumCuenta(123456789);
            c.setNombre("Doraemon");
            c.setSaldo(400);
            c.setTipoInteres(0.03);
            //****************************************************//

            c.EstadoCuenta();

            //****************************************************//
            CuentaAhorro cAhorro = new CuentaAhorro();

            cAhorro.setNumCuenta(65473554);
            cAhorro.setNombre("Suneo");
            cAhorro.setSaldo(100000);
            cAhorro.setTipoInteres(0.01);
            cAhorro.setcuotaMantenimiento(5);
            //****************************************************//

            cAhorro.EstadoCuenta();
        }
    }
}
