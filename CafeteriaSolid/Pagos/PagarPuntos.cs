using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Pagos
{
    public class PagarPuntos : IMetodoPago
    {
       public void ProcesarPago(double monto)
       {
            double puntos = monto * 10;
            Console.WriteLine($"[Sistema] Descuenta los {puntos} del cliente.");
       }
    }
}
