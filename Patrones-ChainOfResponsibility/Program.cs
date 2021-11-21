using System;

namespace Patrones_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "Pedido";

            SpamHandler mailHandler = new SpamHandler();
            mailHandler.AnalizarDireccion(mail);
            Console.ReadKey();
        }
    }
}
