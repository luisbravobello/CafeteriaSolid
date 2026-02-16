using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Notificaciones
{
   public class EnviarSms : INotificacion
   {
        public void EnviarNotificacion()
        {
            Console.WriteLine("Enviando sms al cliente ");
        }
   }
}
