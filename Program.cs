using System;
using MS_Teams_API;

namespace MS_Teams_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            MS_Teams_API.Core CLI = new Core(args);
            CLI.Run();
            Console.WriteLine("You can close this window.");
        }
    }
}
