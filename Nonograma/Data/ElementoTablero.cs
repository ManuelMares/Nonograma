using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nonograma.Data
{
    public class ElementoTablero
    {
        public string Fondo { get; set; }
        public bool Deshabilitado { get; set; }
        public bool Marcado { get; set; }

        public string Numero { get; set; }
        public ElementoTablero(string Fondo, bool Deshabilitado, bool Marcado)
        {
            this.Fondo = "CuadroSinMarcar";
            this.Deshabilitado = false;
            this.Marcado = false;
            Console.WriteLine("Se ha creado un nuevo elemento");
        }


        public void MarcarYBloquear()
        {
            if (Marcado == false)
            {
                Marcado = true;
                Fondo = "CuadoMarcado";
                Deshabilitado = true;
            }
        }

        public void Marcar()
        {

            Console.WriteLine($"entramos al marcado Marcado:{Marcado}");
            if (Marcado == false)
            {
                Marcado = true;
                Fondo = "CuadroMarcado";
                Console.WriteLine($"Ahora el fondo es:{Fondo}");
            }
            else
            {
                Marcado = false;
                Fondo = "CuadroSinMarcar";
            }
        }

        public void Bloquear()
        {
            Deshabilitado = true;
        }

        public void Habilitar()
        {
            Fondo = "CuadroSinMarcar";
            Deshabilitado = false;
            Marcado = false;
        }

    }
}
