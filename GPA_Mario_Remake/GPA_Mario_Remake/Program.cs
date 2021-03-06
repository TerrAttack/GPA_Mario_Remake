﻿using System;

namespace GPA_Mario_Remake
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
            using (var game = new GPA_Mario())
                game.Run();
        }
    }
#endif
}
