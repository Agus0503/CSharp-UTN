using System;

namespace Ejercicio_05A01
{
    class Empresa
    {
        Conductor[] conductores;

        public Empresa(Conductor[] conductores)
        {
            this.conductores = conductores;
        }

        public Conductor ConductorConMasKilometros()
        {
            Conductor conductorConMasKilometros = conductores[0];
            for (int i = 1; i < conductores.Length; i++)
            {
                if (conductores[i].TotalKilometros() > conductorConMasKilometros.TotalKilometros())
                {
                    conductorConMasKilometros = conductores[i];
                }
            }
            return conductorConMasKilometros;
        }

        public Conductor ConductorConMasKilometrosDia(int dia)
        {
            Conductor conductorConMasKilometros = conductores[0];
            for (int i = 1; i < conductores.Length; i++)
            {
                if (conductores[i].kilometros[dia] > conductorConMasKilometros.kilometros[dia])
                {
                    conductorConMasKilometros = conductores[i];
                }
            }
            return conductorConMasKilometros;
        }
    }
}
