// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Nonograma.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Nonograma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\_Imports.razor"
using Nonograma.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
using Nonograma.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
      
    bool bandera = false;
    bool prueba = false;
    int fila = 0;
    int columna = 0;
    bool deshabilitar = true;
    string valor = "";


    public Tablero tablero = new Tablero();
    ControladorNonograma Nonograma = new ControladorNonograma();

    private void ComenzarJuego()
    {
        bandera = true;
    }

    private void CargarNonograma()
    {
    }

    private void SeleccionarCasilla(MouseEventArgs e, int i, int j)
    {
        prueba = true;
        fila = i;
        columna = j;
        tablero.MatrizTablero[fila, columna].Marcado = true;
        tablero.MatrizTablero[fila, columna].Fondo = "CuadroMarcado";
        tablero.MatrizTablero[fila, columna].Numero = "Marcado";
        Console.WriteLine($"Marcado {tablero.MatrizTablero[fila, columna].Marcado} ");
        Console.WriteLine($"Fondo {tablero.MatrizTablero[fila, columna].Fondo} ");
        Console.WriteLine($"Numero {tablero.MatrizTablero[fila, columna].Numero} ");

        //tablero.MarcarDesmarcarElemento(fila, columna);
    }

    private void EnviarNonograma()
    {
        //CreadorNonograma NonogramaCreado = new CreadorNonograma(tablero.MatrizTablero, Nonograma);
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
