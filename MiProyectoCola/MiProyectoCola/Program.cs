using System;
using MiProyectoCola.Services;
using MiProyectoCola.Manager;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el proveedor de cola:");
        Console.WriteLine("1. RabbitMQ");
        Console.WriteLine("2. Amazon SQS");
        Console.WriteLine("3. Azure Queue Storage");
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        IQueueService queueService = opcion switch
        {
            1 => new RabbitMqQueueService(),
            2 => new SqsQueueService(),
            3 => new AzureQueueService(),
            _ => throw new Exception("Opción inválida")
        };

        QueueManager queueManager = new QueueManager(queueService);

        queueManager.AddMessage("Mensaje de prueba");
        queueManager.ProcessMessage();
    }
}
