using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.EternityDesktop.System
{

    /**
     * <summary>Provides the Event object used by EventCore</summary>
     */
    class Event
    {

        /**
         * <summary>The event type.</summary>
         */
        public string event_type;

        /**
         * <summary>Data held by the event</summary>
         */
        public object event_data = null;

        /**
         * <summary>Constructor</summary>
         */

        public Event()
        {
        }

    }
}
