using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.EternityDesktop.System
{

    /**
     * <summary>Provides an event listener used by Event Core.</summary>
     */
    class EventListener
    {

        /**
         * <summary>Event Type</summary>
         */
        public string event_type;

        /**
         * <summary>Event Callback</summary>
         */
        public object event_callback;

        /**
         * Constructor
         */

        public EventListener(string t, object o)
        {
            this.event_callback = o;
            this.event_type = t;
        }

    }
}
