using System;

namespace SqueedBrewDemos
{
    public class ReadOnlyMembers
    {
        public struct SqueedBrew
        {
            public DateTime Datum { get; set; }

            public readonly TimeSpan Nedräkning() => TimeSpan.FromTicks(DateTime.Now.Subtract(Datum).Ticks);

            //public readonly void ÄndraDatum(DateTime nyttDatum)
            //{
            //    Datum = nyttDatum;
            //}
            
        }
    }
}
