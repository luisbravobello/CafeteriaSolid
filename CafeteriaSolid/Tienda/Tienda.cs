using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Tienda
{
    public class Tienda
    {
        // PRINCIPIO DIP (Inversión de Dependencia):
        // Fíjate que usamos las INTERFACES (I...), no las clases (Barista, PagoTarjeta).
        // Esto hace que la Tienda sea flexible.
        private readonly IMetodoPago _pago;
        private readonly IPreparar _preparador;
        private readonly INotificacion _notificacion;

        // Constructor con Inyección de Dependencias:
        // La tienda dice: "Dame ALGO que pague, ALGO que prepare y ALGO que notifique".
        // No le importa qué marca o tipo sean, mientras cumplan el contrato.
        public Tienda(IMetodoPago pago, IPreparar preparador, INotificacion notificacion)
        {
            _pago = pago;
            _preparador = preparador;
            _notificacion = notificacion;
        }

        // Método principal que orquesta todo el proceso
        public void AtenderCliente(double precio)
        {
            Console.WriteLine("\n--- 🛒 Iniciando Venta ---");

            // 1. Llamamos al experto en preparar
            _preparador.PrepararCafe();

            // 2. Llamamos al experto en cobrar
            _pago.ProcesarPago(precio);

            // 3. Llamamos al experto en notificar
            _notificacion.EnviarNotificacion("Gracias por su compra, vuelva pronto.");

            Console.WriteLine("--- Venta Finalizada ---\n");
        }
    }
}
