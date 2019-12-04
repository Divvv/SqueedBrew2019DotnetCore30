using System;

namespace SqueedBrewDemos.PatternMatching
{
    public class PropertyMatching
    {
        public string WhereToHaveLunch(Location tonightLocation) =>
            tonightLocation switch
            {
                { City: "London" } => "Le Gavroche",
                { City: "Paris" } => "Guy Savoy",

                { Country: "Sweden" } => "Fäviken Magasinet",
                
                { Country: "Denmark", City: "Copenhagen" } => "Just go to Malmö.",
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(tonightLocation)),
            };
    }

    public class Location
    {
        public string Country { get; set; }

        public string City { get; set; }
    }
}
