using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Interfaces
{
    // PRINCIPIO ISP:
    // Un contrato exclusivo para procesar pagos.
    // Esto permite que el sistema acepte Tarjetas, Efectivo o Bitcoin en el futuro.
    public interface IMetodoPago
    {
        void ProcesarPago(double monto);
    }
}
