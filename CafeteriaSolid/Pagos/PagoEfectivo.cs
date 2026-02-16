using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Pagos
{
    // [OCP] Principio Abierto/Cerrado
    public class PagoEfectivo : IMetodoPago
    {
        public void ProcesarPago(double  monto)
        {
            Console.WriteLine($" Recibiendo $ {monto} en efectivo ");
        }

    }
}
