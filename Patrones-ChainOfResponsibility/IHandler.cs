using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_ChainOfResponsibility
{
    interface IHandler
    {
        public void Categorizar();

        public void Leer();

        public void PasarSiguiente();
        public void AnalizarDireccion(string direccion);


    }
}
