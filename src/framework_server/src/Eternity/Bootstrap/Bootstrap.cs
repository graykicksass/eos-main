using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Eternity Framework */
using EternityFrameworkServer.Eternity.Core;
using EternityFrameworkServer.Eternity.IO;
using EternityFrameworkServer.Eternity.Framework;

namespace EternityFrameworkServer.Eternity.Bootstrap
{

    /**
     * <summary>Eternity Bootstrap. Provides the main loop of the code and initializes all core classes.</summary>
     */
    class Bootstrap
    {

        public ObjectManagement mObjectsManager;
        public ProcessManagement mProcessManager;
        
        private ETConsole mOut;

        /**
         * <summary>Constructor</summary>
         */

        public Bootstrap()
        {
            
            // Initialize the object manager
            mObjectsManager = new ObjectManagement();

            // Initialize the process manager
            mProcessManager = new ProcessManagement();

            // Add in some of the global framework objects
            mObjectsManager.addInstance(new ETConsole());

            // Add sysd to processes (always one)
            int sysdpid = mProcessManager.addProcess(new ETSystemDaemon());

            // Stage Two
            mOut = (ETConsole)mObjectsManager.getInstance("Eternity.IO.ETConsole");

            mOut.printLn("Eternity Bootstrap - Stage 2");
            mOut.printLn("starting sysd..");

            mProcessManager.getProcess(sysdpid).start();

            // Start the app server thread and bootstrap
            
            // Start the desktop thread and bootstrap
        }

    }
}
