﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual { get => numeroActual; }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente) 
        {
            if (cliente is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
