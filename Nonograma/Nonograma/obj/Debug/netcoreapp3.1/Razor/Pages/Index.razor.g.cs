#pragma checksum "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a72a620f3b4409a6ef8ecb4860416b9a443dc8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "tablero");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                      ComenzarJuego

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, " Maquina ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, " <hr>");
#nullable restore
#line 8 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
     if (bandera == true)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "juego");
#nullable restore
#line 11 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
             for (int i = 0; i < 5; i++)
            {
                int contadorI = i;
                for (int j = 0; j < 5; j++)
                {
                    int contadorJ = j;
                    tablero.MatrizTablero[contadorI, contadorJ] = new ElementoTablero("CuadroSinMarcar", false, false);
                    valor = contadorI + "/" + contadorJ;
                    tablero.MatrizTablero[contadorI, contadorJ].Numero = valor;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                                         e=> SeleccionarCasilla(e, contadorI, contadorJ) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", 
#nullable restore
#line 21 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                                     tablero.MatrizTablero[contadorI, contadorJ].Fondo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, 
#nullable restore
#line 21 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                                                                                          valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                }

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"
                          EnviarNonograma

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, " Maquina ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, " <hr>");
#nullable restore
#line 27 "C:\Users\Manuel\source\repos\Nonograma\Nonograma\Pages\Index.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
