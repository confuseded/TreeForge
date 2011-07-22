using System;

namespace TreeForge
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (TreeForge game = new TreeForge())
            {
                game.Run();
            }
        }
    }
#endif
}

