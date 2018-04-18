using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesebrera.NEGOCIO
{
    class Clasificacion
    {
        // Método que contiene el criterio de Claficicación de bovinos y equinos
        public char ClasificaBovinoEquino(string lineaTexto)
        {
            if (lineaTexto.ToUpper().Contains("B"))
                return 'B';
            else
                return 'E';
        }
    }
}
