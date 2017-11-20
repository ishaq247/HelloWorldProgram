﻿using SharedAPI;
using SharedAPI.Applications;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceApi service = new ServiceApi();
            Task<string> result = service.GetMessage();
            Console.WriteLine(result.Result);    
            Console.ReadLine();
        }
    }
}
