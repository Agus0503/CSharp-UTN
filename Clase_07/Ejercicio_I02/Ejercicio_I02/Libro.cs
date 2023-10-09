using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }

        public string this[int i]
        {
            get 
            {
                if (i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return string.Empty;
                }
            }

            set
            {
                if (i >= 0)
                {
                    if (i < paginas.Count)
                    {
                        paginas[i] = value;
                    }
                    else
                    {
                        paginas.Add(value);
                    }
                }
            }
        }
    }
}
