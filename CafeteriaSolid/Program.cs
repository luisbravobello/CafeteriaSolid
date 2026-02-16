using CafeteriaSolid.Interfaces;
using CafeteriaSolid.Notificaciones;
using CafeteriaSolid.Pagos;
using CafeteriaSolid.Personal;
using CafeteriaSolid.Tienda;

namespace MiCafeteriaSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Preparamos nuestras piezas (Dependencias)
            IPreparar miBarista = new Barista();
            // 2. Escenario A: Cliente que paga con Tarjeta
            IMetodoPago Puntos = new PagoTarjeta();

            IMetodoPago Efectivo = new PagoEfectivo();

            INotificacion sms = new EnviarSms();

            INotificacion correo = new EnviarCorreo();

            // Inyectamos las dependencias en la tienda
            Tienda pedido1 = new Tienda(Efectivo, miBarista, sms);
            pedido1.AtenderClientes(160);

            // -------------------------------------------------

            // 3. Escenario B: Cliente que paga con Puntos
            // Fíjate que reutilizamos al Barista (SRP) pero cambiamos el pago (OCP/LSP)
            IMetodoPago pagoConEfectivo= new PagoEfectivo();

            Tienda pedido2 = new Tienda(Puntos, miBarista, correo);
            pedido2.AtenderClientes(45.5);

            Console.ReadKey();
        }
    }

}
