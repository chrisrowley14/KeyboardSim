using System;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;

namespace ESPApp
{
    public class Program
    {
        public static void Main()
        {
            SerialPort serial = new SerialPort("COM1", 9600);
            serial.ReadTimeout = 5000;
            serial.Open();

            while (true)
            {
                try
                {
                    string receivedText = serial.ReadLine();
                    string receivedDelay = serial.ReadLine();
                    int delayInSeconds = int.Parse(receivedDelay);

                    serial.WriteLine($"Received Text: {receivedText}");
                    serial.WriteLine($"Received Delay: {delayInSeconds} seconds");

                    Thread.Sleep(delayInSeconds * 1000);

                }
                catch (Exception ex)
                {
                    serial.WriteLine($"Error: {ex.Message}");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
