using System;
using System.IO;
using System.Net;

namespace DotnetWS.DesignPatterns.Adapter 
{
    public class Car : IDrive 
    {
        public void Start()
        {
            Console.WriteLine("Car is running.");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped.");
        }
    }
}