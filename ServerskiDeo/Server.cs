using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Server
    {
        private Socket socket;
        private List<ClientHandler> clientHandlers;

        public Server()
        {
            clientHandlers = new List<ClientHandler>();
        }

        public bool Start()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(endPoint);
                socket.Listen(10);
                return true;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                return false;
            }
        }

        public void Stop()
        {
            try
            {
                foreach (ClientHandler handler in clientHandlers)
                {
                    handler.Close();
                }
                socket.Close();
                socket = null;
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Ceka se klijent");
                    Socket klijent = socket.Accept();
                    Console.WriteLine("Klijent prihvacen");
                    ClientHandler ch = new ClientHandler(klijent);
                    clientHandlers.Add(ch);
                    Thread nit = new Thread(ch.HandleRequest);
                    nit.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
    }
}
