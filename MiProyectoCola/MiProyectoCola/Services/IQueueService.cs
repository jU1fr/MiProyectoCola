using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyectoCola.Services
{
    public interface IQueueService
    {
        void Enqueue(string message);
        string Dequeue();
    }
}

