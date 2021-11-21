using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_ChainOfResponsibility
{
    class SugerenciasHandler : IHandler
    {
        PedidosHandler siguienteHandler = new PedidosHandler();
        public string Direccion { get; private set; }

        public void AnalizarDireccion(string direccion)
        {
            Direccion = direccion;
            if (direccion == "Sugerencia")
            {
                Leer();
                Categorizar();
            }
            else
            {
                PasarSiguiente();
            }
        }

        public void Categorizar()
        {

            Console.WriteLine("Enviando al archivo de Sugerencia");
        }

        public void Leer()
        {
            Console.WriteLine("Leyendo el mail");
        }

        public void PasarSiguiente()
        {
            siguienteHandler.AnalizarDireccion(Direccion);
        }
    }
}
