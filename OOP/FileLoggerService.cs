﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
