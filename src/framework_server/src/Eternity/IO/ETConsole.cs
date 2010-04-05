using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EternityFrameworkServer.Eternity.Core;

namespace EternityFrameworkServer.Eternity.IO
{

    /**
     * <summary>ETConsole is the Eternity framework generic text output wrapper.</summary>
     */
    class ETConsole : IETInstance
    {

        // ET Instance
        public static string TAG = "Eternity.IO.ETConsole";

        // Local

        private int mOutputMethod = 0; // 0 defaults to console
        private string mOutputBuffer;

        /**
         * <summary>Constructor</summary>
         */

        public ETConsole()
        {

            mOutputMethod = 0;
            mOutputBuffer = "";

        }

        /**
         * <summary>Write a line to the current output stream.</summary>
         */
        public void printLn(string o)
        {
            if (mOutputMethod == 0)
            {
                Console.WriteLine(o);
            }

            mOutputBuffer += o + "\n";

            return;
        }

        /**
         * <summary>Write a string to the output stream.</summary>
         */
        public void print(string o)
        {

            if (mOutputMethod == 0)
            {
                Console.Write(o);
            }

            mOutputBuffer += o;

            return;
        }

        /**
         * <summary>clears the current output buffer</summary>
         */
        public void clear()
        {
            if (mOutputMethod == 0)
            {
                Console.Clear();
            }

            mOutputBuffer = "";
        }

        /**
         * <summary>Returns a string representation of this object</summary>
         */

        public string toString()
        {

            return("Eternity IO Console Object");

        }

        /**
         * <summary>Returns the tag of this object</summary>
         */

        public string getTag()
        {
            return (TAG);
        }

    }
}
