﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        public override double CalcularPerimetro()
        {
            return (longitudBase + longitudAltura) * 2;
        }

        public override double CalcularSuperficie()
        {
            return longitudBase * longitudAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }
    }
}
