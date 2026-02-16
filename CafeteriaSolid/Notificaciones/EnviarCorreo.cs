using CafeteriaSolid.Interfaces;
using System;

namespace CafeteriaSolid.Notificacion
{
    // PRINCIPIO SRP (Responsabilidad Única):
    // Esta clase tiene una ÚNICA razón para cambiar: si cambia la forma 
    // en que enviamos correos (ej. cambiamos de Gmail a Outlook).
    // No sabe nada de café, ni de cobros.
    public class EnviarCorreo : INotificacion
    {
        // PRINCIPIO LSP (Sustitución de Liskov):
        // Esta clase cumple fielmente el contrato de 'INotificacion'.
        // Cualquier parte del código que espere una 'INotificacion' puede usar
        // esta clase sin que el programa falle o se comporte raro.
        public void EnviarNotificacion(string mensaje)
        {
            // Lógica específica de Correo (Simulada)
            Console.WriteLine($"📧 Enviando su notificacion con su informacion: {mensaje}");
        }
    }
}