using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Interfaces
{
    // PRINCIPIO ISP:
    // Un contrato exclusivo para notificaciones.
    // Así separamos la lógica de "avisar" de la lógica de "vender".
    public interface INotificacion
    {
        void EnviarNotificacion(string mensaje);
        
    }
}
