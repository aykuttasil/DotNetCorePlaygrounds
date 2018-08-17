using System;
using System.Threading.Tasks;
using dependency_injection.Interfaces;
using Microsoft.Extensions.Logging;

namespace dependency_injection.Services
{
    class MyLogServices : ILog
    {

        private readonly ILogger<MyLogServices> _logger;

        public MyLogServices(ILogger<MyLogServices> logger)
        {
            this._logger = logger;
        }

        public void write(string msg)
        {
            Console.WriteLine(msg);
        }

        public Task WriteMessage(string message)
        {
            _logger.LogInformation("MyLogServices.WriteMessage called. Message: {MESSAGE}", message);
            return Task.FromResult(0);
        }
    }
}