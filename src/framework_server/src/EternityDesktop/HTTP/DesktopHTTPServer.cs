using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Net Imports
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace EternityFrameworkServer.EternityDesktop.HTTP
{

    /**
     * <summary>This provides the desktop HTTP server used by Eternity to bridge the framework and desktop.</summary>
     */
    class DesktopHTTPServer
    {

        // TCP Listener and Thread
        private TcpListener tcpListener;
        private Thread listenThread;

        /**
         * <summary>Constructor</summary>
         */
        public DesktopHTTPServer() {

            this.tcpListener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(ListenForDesktop));
            this.listenThread.Start();

        }

        /**
         * <summary>Provides the client listening thread</summary>
         */
        private void ListenForDesktop()
        {

            this.tcpListener.Start();

            while (true)
            {
                // Continue blocking this thread until an application comes.
                TcpClient client = this.tcpListener.AcceptTcpClient();

                // Create a thread for the connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(processClient));
                clientThread.Start(client);
            }
        }

        /**
         * <summary>Client Communication Handler</summary>
         */

        private void processClient(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            // Add postdata to parse stack.

            // Send buffer
        }




    }
}
