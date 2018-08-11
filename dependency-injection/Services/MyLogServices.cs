using System;
using dependency_injection.Interfaces;

namespace dependency_injection.Services
{
    class MyLogServices : ILog
    {
        public void write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}