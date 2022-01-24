using System;
using System.IO;

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