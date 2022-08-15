// See https://aka.ms/new-console-template for more information

namespace UnityServerTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";

            Server.Start(50, 26950);
            
            Console.ReadKey();
        }
    }
}