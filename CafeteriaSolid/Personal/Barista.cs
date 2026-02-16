using CafeteriaSolid.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeteriaSolid.Personal
{
     public class Barista : IPreparar
     {
        public void PrepararCafe()
        {
            Console.WriteLine("[Barista] preparando su cafe....");
        }
     }
}
