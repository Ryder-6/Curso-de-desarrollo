using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaccion transaccion = new Transaccion(20, "Porque sí");
            Cuenta cuenta = new Cuenta("Nacho");
            cuenta.AnadirTransaccion(transaccion);
            cuenta.AnadirTransaccion(transaccion);
            cuenta.AnadirTransaccion(transaccion);
            cuenta.MostrarTransacciones();
        }
    }
}
