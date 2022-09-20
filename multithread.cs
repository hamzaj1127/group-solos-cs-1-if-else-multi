using System;
using System.Threading;
namespace threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread uno = new Thread(dos);
            uno.Start();
            Console.WriteLine("uno is working");
            Console.ReadKey();
        }
        static void dos()
        {
            Console.WriteLine("dos is working");
        }
    }
}