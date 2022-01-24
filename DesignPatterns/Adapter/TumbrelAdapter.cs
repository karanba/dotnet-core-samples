using System;

namespace DotnetWS.DesignPatterns.Adapter 
{
    public class TumbrelAdapter : IDrive
    {
        private readonly Tumbrel tumbrel;
        public TumbrelAdapter(Tumbrel tumbrel)
        {
            this.tumbrel = tumbrel;
        }

        public void Start()
        {
            this.tumbrel.GoOn();
            Console.WriteLine("Tumbrel is riding.");
        }

        public void Stop()
        {
            this.tumbrel.Whoa();
            Console.WriteLine("Tumbrel is stop.");
        }
    }
}