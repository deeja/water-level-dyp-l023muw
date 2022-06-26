using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace DepthSensorReader
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var cancellationToken = source.Token;
            
            Console.WriteLine("Let's go!");
            Console.WriteLine("Blue led alternates on and off when liquid is detected");

            Console.WriteLine("Press any key to stop");
            var task = Task.Run(() => Listen(cancellationToken),CancellationToken.None);
            Console.ReadKey(true);
            source.Cancel();
            await task;
        }

        private static void Listen(CancellationToken cancellationToken)
        {
            using var serialPort = new SerialPort("COM7", 9600, Parity.None, 8, StopBits.One)
                {Handshake = Handshake.None};

            serialPort.Open();
            
            // Write some bytes to start the feedback
            serialPort.Write("Triggered!");

            while (!cancellationToken.IsCancellationRequested)
            {
                var firstByte = serialPort.ReadByte();
                if (firstByte != 0xFF)
                {
                    Console.WriteLine("Waiting for the start byte");
                    continue;
                }

                var dataHigh = serialPort.ReadByte();
                var dataLow = serialPort.ReadByte();
                var dataSum = serialPort.ReadByte();

                var level = dataHigh * 256 + dataLow;

                var sum = (firstByte + dataHigh + dataLow) & 0x00FF;

                if (sum != dataSum)
                {
                    Console.WriteLine("Bad Sum");
                }

                Console.WriteLine($"{DateTimeOffset.Now:u} Level: {level} ");
            }
        }
    }
}