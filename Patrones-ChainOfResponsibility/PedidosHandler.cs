using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_ChainOfResponsibility
{
    class PedidosHandler : IHandler
    {

       
        public string Direccion { get; private set; }

        public void AnalizarDireccion(string direccion)
        {
            Direccion = direccion;
            if (direccion == "Pedido")
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

            Console.WriteLine("Enviando al archivo de Pedidos");
        }

        public void Leer()
        {
            Console.WriteLine("Leyendo el mail");
        }

        public void PasarSiguiente()
        {
            Console.WriteLine("El mail no ha podido categorizarse");
        }
    }
}
