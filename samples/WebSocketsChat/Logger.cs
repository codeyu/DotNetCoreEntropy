using System;
namespace WebSocketServer
{


public class Logger


    {
        public bool LogEvents { get; set; }

        public Logger()
        {
            LogEvents = true;
        }

        public void Log(string Text)
        {
            if (LogEvents) Console.WriteLine(Text);
        }
    }
}