using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace MiProyectoCola.Services
{
    public class SqsQueueService : IQueueService
    {
        private Queue<string> _queue = new Queue<string>();

        public void Enqueue(string message)
        {
            _queue.Enqueue(message);
            Console.WriteLine($"[Amazon SQS] Mensaje encolado: {message}");
        }

        public string Dequeue()
        {
            if (_queue.Count > 0)
            {
                string message = _queue.Dequeue();
                Console.WriteLine($"[Amazon SQS] Mensaje desencolado: {message}");
                return message;
            }
            Console.WriteLine("[Amazon SQS] La cola está vacía.");
            return null;
        }
    }
}

