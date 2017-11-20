using SharedAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI
{
    public class ConsoleApp : IWriteMessage
    {
         public void WriteText(string message)
        {
            Console.WriteLine(message);
        }
    }
}
