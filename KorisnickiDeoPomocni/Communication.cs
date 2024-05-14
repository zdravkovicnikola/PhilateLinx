using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;

        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }
        private Communication()
        {
        }

        public void Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("<<<" + ex.Message);
                throw;
            }
        }

    }
}
