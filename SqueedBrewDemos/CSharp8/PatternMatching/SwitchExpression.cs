using System;

namespace SqueedBrewDemos.PatternMatching
{
    public class SwitchExpression
    {
        public string WhereToHaveLunch(City city) =>
            city switch
            {
                City.London => "Le Gavroche",
                City.Paris => "Guy Savoy",
                City.Barcelona => "La Dama",
                City.NewYork => "McDonalds",
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(city)),
            };

        public enum City
        {
            London,
            Paris,
            Barcelona,
            NewYork
        }
    }
}
