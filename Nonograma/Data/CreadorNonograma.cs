using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nonograma.Data
{
    public class CreadorNonograma
    {

        public CreadorNonograma(ElementoTablero[,] tablero, ControladorNonograma Nonograma)
        {
            Nonograma.BloquearTablero(tablero);
        }
    }
}
