using CafeteriaSolid.Interfaces;
using CafeteriaSolid.Notificacion;
using CafeteriaSolid.Pagos;
using CafeteriaSolid.Personal;
using CafeteriaSolid.Tienda;

namespace MiCafeteriaSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA SOLID ===");

            // 1. Configuración de piezas (Dependencias)
            // Aquí elegimos qué "piezas" usaremos hoy.
            IPreparar miBarista = new Barista();
            INotificacion miCorreo = new EnviarCorreo();
            IMetodoPago pagoTarjeta = new PagoTarjeta();
            IMetodoPago pagoEfectivo = new PagoEfectivo();

            // --- ESCENARIO 1: Cliente con Tarjeta ---
            Console.WriteLine("\n[Caso 1: Cliente paga con Tarjeta]");

            // Creamos la pieza específica de pago


            // Inyectamos las piezas en la tienda
            Tienda tiendaUno = new Tienda(pagoTarjeta, miBarista, miCorreo);

            // Ejecutamos
            tiendaUno.AtenderCliente(150.00);


            // --- ESCENARIO 2: Cliente con Efectivo ---
            // Fíjate que REUTILIZAMOS la clase Tienda, solo cambiamos la pieza de pago.
            Console.WriteLine("\n[Caso 2: Cliente paga con Efectivo]");



            Tienda tiendaDos = new Tienda(pagoEfectivo, miBarista, miCorreo);
            tiendaDos.AtenderCliente(50.00);

            Console.ReadKey();

            // El Program ya no sabe de pagos, ni de baristas, ni de correos.
            // Solo sabe que existe un Menu y lo arranca.
            /*MenuPrincipal menu = new MenuPrincipal();
            menu.Iniciar();*/
        }
    }

}
