using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection.Interfaces
{
    public interface ILog
    {
        void write(string msg);
    }
}