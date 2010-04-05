using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EternityFrameworkServer.EternityDesktop.System
{

    /**
     * <summary>This provides the UI event core.</summary>
     */

    class EventCore
    {

        private List<Event> mEvents;

        /**
         * <summary>Constructor</summary>
         */

        public EventCore()
        {
            mEvents = new List<Event>();
        }

    }
}
