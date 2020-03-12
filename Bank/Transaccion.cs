using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public struct Transaccion
    {
        public int cantidad;
        public string concepto;

        public Transaccion(int cantidad, string concepto)
        {
            this.cantidad = cantidad;
            this.concepto = concepto;
        }

        public override string ToString()
        {
            string info = "";
            info += "Cantidad: " + cantidad;
            info += "\n";
            info += "Concepto: " + concepto;
            return info;
        }
    }
}
