using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Interfaces
{
    public interface IMetodoPago
    {
        void ProcesarPago(double monto);
    }
}
