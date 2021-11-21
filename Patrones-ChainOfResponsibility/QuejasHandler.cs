using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_ChainOfResponsibility
{
    class QuejasHandler : IHandler
    {
        SugerenciasHandler siguienteHandler = new SugerenciasHandler();
        public string Direccion { get; private set; }

        public void AnalizarDireccion(string direccion)
        {
            Direccion = direccion;
            if (direccion == "Queja")
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

            Console.WriteLine("Enviando al archivo de Quejas");
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
