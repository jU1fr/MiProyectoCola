using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiProyectoCola.Services;

namespace MiProyectoCola.Manager
{
    public class QueueManager
    {
        private readonly IQueueService _queueService;

        public QueueManager(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public void AddMessage(string message)
        {
            _queueService.Enqueue(message);
        }

        public void ProcessMessage()
        {
            _queueService.Dequeue();
        }
    }
}

