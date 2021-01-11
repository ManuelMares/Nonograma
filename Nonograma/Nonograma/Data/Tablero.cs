using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nonograma.Data
{
    public class Tablero
    {
        public ElementoTablero[,] MatrizTablero = new ElementoTablero[5,5];
        public Tablero()
        {
        }

        public ElementoTablero ObtenerElemento (int fila, int columna)
        {
            Console.WriteLine($"Elemento a Obtener: fila {fila}, columna: {columna}");
            ElementoTablero elemento = MatrizTablero[fila, columna];
            return elemento;
        }

        public string ObtenerFondoDeElemento(int fila, int columna)
        {
            string fondo = ObtenerElemento(fila, columna).Fondo;
            return fondo;
        }

        public bool ElementoEstaHabilitado(int fila, int columna)
        {
            bool habilitado = ObtenerElemento(fila, columna).Deshabilitado;
            return habilitado;
        }

        public void MarcarDesmarcarElemento(int fila, int columna)
        {

            Console.WriteLine($"fila: {fila}, columna: {columna}");
            foreach(var elemento in MatrizTablero)
            {
                Console.WriteLine($"elemento: {elemento},    Marcado : {elemento.Marcado},  Fondo: {elemento.Fondo}");
            }

            MatrizTablero[fila, columna].Marcar();

            foreach (var elemento in MatrizTablero)
            {
                Console.WriteLine($"elemento: {elemento},    Marcado : {elemento.Marcado},  Fondo: {elemento.Fondo}");
            }
        }
    }
}
