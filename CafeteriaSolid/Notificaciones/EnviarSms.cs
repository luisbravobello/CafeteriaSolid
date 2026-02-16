using CafeteriaSolid.Interfaces;
using System;

namespace CafeteriaSolid.Notificacion
{
    // PRINCIPIO OCP (Abierto/Cerrado):
    // Aquí es donde brilla este principio. 
    // El sistema estaba "Cerrado" a modificación (no tuviste que borrar EnviarCorreo),
    // pero estaba "Abierto" a extensión (pudiste crear EnviarSMS para añadir funcionalidad nueva).
    public class EnviarSMS : INotificacion
    {
        public void EnviarNotificacion(string mensaje)
        {
            // PRINCIPIO DIP (Inversión de Dependencias) - Parte Baja:
            // Estas clases (Correo y SMS) son los "detalles de bajo nivel".
            // Implementan la abstracción (INotificacion) para que la clase Tienda (Alto Nivel)
            // pueda usarlas sin depender directamente de ellas.
            Console.WriteLine($"📱 Se envio su mensaje por SMS: {mensaje}");
        }
    }
}