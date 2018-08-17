using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace dependency_injection.Interfaces
{
    public interface ILog
    {
        void write(string msg);

        Task WriteMessage(string message);
    }
}