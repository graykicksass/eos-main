using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EternityFrameworkServer.Eternity.Core;
using EternityFrameworkServer.Eternity.IO;

namespace EternityFrameworkServer.Eternity.AppServer
{

    /**
     * <summary>App Client represents a connected application (remote)</summary>
     */
    class AppClient : IETProcess
    {

        /* Process Variables */

        public int mPid;

        /* Process Functions */

        public bool processState()
        {
            // If the system is running, the daemon is running
            return (true);
        }

        public string getProcessName()
        {
            return ("sysd");
        }

        public string getProcessDescription()
        {
            return ("Eternity System Process");
        }

        public void start()
        {

            // Entry Point for sysd

        }

        public bool end()
        {
            return (false);
        }

        public bool forcestop()
        {
            return (false);
        }

        public int pid()
        {
            return mPid;
        }

        public void setPid(int p)
        {
            mPid = p;
            return;
        }

    }
}
