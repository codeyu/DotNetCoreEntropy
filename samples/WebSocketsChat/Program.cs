using System;

namespace WebSocketServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebSocketServerTest WSServerTest = new WebSocketServerTest();
            WSServerTest.Start();
        }
    }
}
