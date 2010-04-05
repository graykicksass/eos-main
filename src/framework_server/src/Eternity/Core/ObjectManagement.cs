using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.Eternity.Core
{

    /**
     * <summary>Object Manager (Semi-Singleton Model)</summary>
     */
    class ObjectManagement
    {

        private List<IETInstance> mObjects;

        /**
         * <summary>Constructor</summary>
         */
        public ObjectManagement()
        {

            mObjects = new List<IETInstance>();

        }

        /**
         * <summary>Adds a new instance (must implement IETInstance) to the pool</summary>
         */

        public void addInstance(IETInstance o)
        {

            mObjects.Add(o);

            return;

        }

        /**
         * <summary>Retrieves an instance by it's tag. Returns 0 if not found</summary>
         */

        public object getInstance(string tag)
        {

            foreach (IETInstance o in mObjects)
            {

                if (o.getTag() == tag)
                {
                    return o;
                }

            }

            return 0;

        }

    }
}
