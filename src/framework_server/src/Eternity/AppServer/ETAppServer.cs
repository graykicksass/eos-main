using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Net Imports
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace EternityFrameworkServer.Eternity.AppServer
{

    /**
     * <summary>The Eternity Application Binding Server (Provides interface to the API)</summary>
     */
    class ETAppServer
    {

        // TCP Listener and Thread
        private TcpListener tcpListener;
        private Thread listenThread;

        /**
         * <summary>Constructor</summary>
         */
        public ETAppServer()
        {

            this.tcpListener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(ListenForApplications));
            this.listenThread.Start();

        }

        /**
         * <summary>Provides the client listening thread</summary>
         */
        private void ListenForApplications()
        {

            // TODO: Handle App reconnection if dropped (?)
            
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

            // Send the 'hello' message to the app
            byte[] buffer = new byte[2];
            buffer[1] = 0x01; // Message Type (0x01 = hello)
            buffer[2] = 0x00; // Message Terminator

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();

            // TODO: Create app client object, add it to pool.
        }

    }
}
