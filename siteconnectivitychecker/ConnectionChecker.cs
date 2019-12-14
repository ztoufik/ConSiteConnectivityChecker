using System;
using System.Net.Sockets;

namespace siteconnectivitychecker
{
    public static class ConnectionChecker
    {
        private const int portNum = 80;

        public static bool ConnectionCheck(string hostName)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var result = socket.BeginConnect(hostName,portNum, null, null);
            bool success = result.AsyncWaitHandle.WaitOne(3000, false); // test the connection for 3 seconds
            var resturnVal = socket.Connected;
            if (socket.Connected)
                socket.Disconnect(true);
            socket.Dispose();
            return resturnVal;
        }
    }
}
