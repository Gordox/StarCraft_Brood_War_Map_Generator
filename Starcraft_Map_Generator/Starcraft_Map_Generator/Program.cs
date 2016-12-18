using Starcraft_Map_Generator.World;
using System;

namespace Starcraft_Map_Generator
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Console.Write("HEJSAN ALLIHOPA: "+c);

            using (var game = new Generator())
                game.Run();

            
        }
    }
#endif
}
