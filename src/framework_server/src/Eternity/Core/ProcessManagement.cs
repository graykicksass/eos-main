using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.Eternity.Core
{

    /**
     * Process Management is the pool for process representation objects.
     */
    class ProcessManagement
    {

        private List<IETProcess> mProcesses;
        private int curPid = 0;

        /**
         * Constructor
         */
        public ProcessManagement()
        {
            
            // Initialize the processes list
            mProcesses = new List<IETProcess>();

        }

        /**
         * <summary>This will add an object implementing IETProcess to the process pool. Returns PID</summary>
         */
        public int addProcess(IETProcess o)
        {
            curPid++; // Increment the current process ID number

            o.setPid(curPid);
            mProcesses.Add(o);
            return curPid;
        }

        /**
         * <summary>This will retrieve a process by it's pid. Returns null if not found.</summary>
         */

        public IETProcess getProcess(int pid)
        {

            foreach (IETProcess o in mProcesses)
            {

                if (o.pid() == pid)
                {
                    return o;
                }

            }

            return null;

        }

        /**
         * <summary>This will remove a process object if it's processState() returns false. Returns true if removed, false if not</summary>
         */
        public bool removeProcess(int pid)
        {

            foreach (IETProcess o in mProcesses) {

                if (o.pid() == pid)
                {
                    if (o.processState() == false)
                    {
                        mProcesses.Remove(o);
                        return(true);
                    }
                }

            }

            return(false);

        }

    }
}
