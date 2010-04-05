using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Eternity Framework Imports */
using EternityFrameworkServer.Eternity.Bootstrap;

namespace EternityFrameworkServer
{
    class Program
    {
        static void Main(string[] args)
        {

            // Setup the bootstrap
            Bootstrap EternityOS = new Bootstrap();

            Console.ReadKey(); // Wait after done.

        }
    }
}
