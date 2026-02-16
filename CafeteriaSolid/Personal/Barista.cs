using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Personal
{
    // [SRP] Principio de Responsabilidad Única
    // Esta clase tiene una sola razón para cambiar: Si cambia la forma de preparar café.
    public class Barista : IPreparar
     {
        public void PrepararCafe()
        {
            Console.WriteLine("[Barista] preparando su cafe....");
        }
     }
}
