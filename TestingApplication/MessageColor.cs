using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApplication
{
   class MessageColor
    {
       public void ReadMessage(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GreenMessage(string message)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
