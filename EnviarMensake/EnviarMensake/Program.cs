using System;

namespace EnviarMensake
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            string destino;
            Console.WriteLine("Digite el mensaje que desea enviar...");
            mensaje = Console.ReadLine();
            Console.WriteLine("{0}",mensaje);
            Console.WriteLine("Digite el nombre del destinatario...");
            destino = Console.ReadLine();
            Console.WriteLine("Enviando mensaje '{0}' a su destino '{1}'", mensaje, destino);
        }
    }
}
