using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Interfaces
{
    // PRINCIPIO ISP (Segregación de Interfaz):
    // Creamos una interfaz solo para "Preparar". 
    // No obligamos al Barista a saber "Cobrar" o "EnviarEmails".
    public interface IPreparar
    {
        void PrepararCafe();
    }
}