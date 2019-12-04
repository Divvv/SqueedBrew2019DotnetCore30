namespace SqueedBrewDemos.PatternMatching
{
    public class TuplePatterns
    {
        public string WhereToHaveLunch(string tonightCity, string tonightCountry) =>
           (tonightCity, tonightCountry) switch
           {
               ( "England", "London" ) => "Le Gavroche",
               ( "France", "Paris" ) => "Guy Savoy",
               ( "Sweden", "Gothenburg" ) => "Hemma hos Örjan",
               ( "Denmark", "Copenhagen" ) => "Just go to Malmö.",
               (_, _) => "Find something yourself!"
           };
    }
}
