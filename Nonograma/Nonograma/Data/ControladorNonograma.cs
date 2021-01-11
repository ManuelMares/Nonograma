using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nonograma.Data
{
    public class ControladorNonograma
    {
        public bool Bandera { get; set; }
        public bool Victoria { get; set; }


        public ControladorNonograma()
        {
        }

        public void ObtenerIndices()
        {
            //foreach(var fila in tablero)
            {

            }
        }
        public void BloquearTablero(ElementoTablero[,] tablero)
        {
            int i = 0;
            int j = 0;
            foreach (var elemento in tablero)
            {
                i++;
                tablero[i, j].Bloquear();
                if (i == 4)
                {
                    j++;
                    i = 0;
                }
            }
        }

        public void DibujarTableroBlanco()
        {

        }
        
        public void CrearNonogramaAleatorio()
        {

        }


    }
}
