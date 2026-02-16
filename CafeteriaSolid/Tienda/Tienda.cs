using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Tienda
{
    public class Tienda
    {
        private readonly IMetodoPago _metodoPago;
        private readonly IPreparar _preparar;
        private readonly INotificacion _notificacion;

        public Tienda(IMetodoPago metodoPago, IPreparar preparar, INotificacion notificacion)
        {
            _metodoPago = metodoPago;
            _preparar = preparar;
            _notificacion = notificacion;
        }

        public void AtenderClientes(double precio)
        {
            Console.WriteLine(" Nuevo CLiente");
            _preparar.PrepararCafe();
            _metodoPago.ProcesarPago(precio);
            _notificacion.EnviarNotificacion();
            Console.WriteLine(" --------------------------------------");
        }
    }
}
