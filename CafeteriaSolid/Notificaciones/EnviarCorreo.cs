using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Notificaciones
{
    public class EnviarCorreo : INotificacion
    {
         public void EnviarNotificacion()
         {
            Console.WriteLine("Enviando mensaje por correo ");
           
         }
    }
}
