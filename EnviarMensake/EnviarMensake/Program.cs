using System;

namespace EnviarMensake
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            Console.WriteLine("Digite el mensaje que desea enviar...");
            mensaje = Console.ReadLine();
            Console.WriteLine("{0}",mensaje);
        }
    }
}
