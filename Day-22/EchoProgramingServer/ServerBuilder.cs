using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoProgramingServer
{
    public class ServerBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8080;
        private TcpListener _listener;
        private Socket _socket;

        public void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);
        }

        public void Run()
        {
            Build();
            _listener.Run();
            System.Console.WriteLine($"App is listening on {ipAddress}:{port}.");

            _socket = _listener.AcceptSocket();
            System.Console.WriteLine("Client connected.");
            return _socket;
        }

        public void ShutDown()
        {
            _socket.Close();
            _listener.Stop();

        }
    }
