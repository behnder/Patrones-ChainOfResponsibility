using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_ChainOfResponsibility
{
    class SpamHandler : IHandler
    {
        QuejasHandler siguienteHandler = new QuejasHandler();
        public string Direccion { get;private set; }

        public void AnalizarDireccion(string direccion)
        {
            Direccion = direccion;
            if (direccion == "Spam")
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
           
            Console.WriteLine("Enviando al archivo de Spam");
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
