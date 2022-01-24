using System;
using DotnetWS.DesignPatterns.Adapter;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.TestAdapterPattern();
        }

        static void TestAdapterPattern()
        {
            IDrive[] drives = {
                new Car(),
                new TumbrelAdapter(new Tumbrel())
            };

            foreach(var drive in drives)
            {
                drive.Start();
                drive.Stop();
            }
        }
    }
}
