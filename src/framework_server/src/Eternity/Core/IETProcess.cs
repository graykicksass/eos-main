using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.Eternity.Core
{

    /**
     * <summary>Represents a process in Eternity's process pool.
     * 
     * Should be implemented by either a remote process host or internal application.</summary>
     */

    interface IETProcess
    {

        /**
         * <summary>The eternity PID of this process</summary>
         */
        int pid();

        /**
         * <summary>Store pid</summary>
         */
        void setPid(int p);

        /**
         * <summary>This should always be the active state of the process.</summary>
         */
        bool processState();

        /**
         * <summary>This should be the name of the process</summary>
         */
        string getProcessName();

        /**
         * <summary>This should return the 'description' of the process.</summary>
         */
        string getProcessDescription();

        /**
         * <summary>
         *  This should start the process.
         * </summary>
         */
        void start();

        /**
         * <summary>
         *  This is a 'friendly end'. Which will tell the application to stop (if possible) in something like a shutdown event.
         *  
         *  If false is returned, the user will be asked if the process should be 'force stopped'
         * </summary>
         */

        bool end();

        /**
         * <summary>Force stop should kill the remote process. Will return false if process is critical and cannot be killed.</summary>
         */
        bool forcestop();

    }
}
