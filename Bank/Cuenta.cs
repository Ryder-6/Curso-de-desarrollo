using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Cuenta
    {
        public string nombrePropietario;
        public List<Transaccion> transacciones;

        public Cuenta(string nombrePropietario)
        {
            this.nombrePropietario = nombrePropietario;
            transacciones = new List<Transaccion>();
        }

        public void AnadirTransaccion(Transaccion transaccion)
        {
            transacciones.Add(transaccion);
        }

        public void MostrarTransacciones()
        {
            Console.WriteLine("Transacciones: ");
            for (int i = 0; i < transacciones.Count; i++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(transacciones[i].ToString());
                Console.WriteLine("----------------");
            }
        }
    }
}
