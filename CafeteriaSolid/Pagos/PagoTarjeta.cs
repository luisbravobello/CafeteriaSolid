using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Pagos
{
    public class PagoTarjeta : IMetodoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($" Procesando tarjeta por el $ {monto}...");
        }
    }
}
