namespace SqueedBrewDemos
{
    public class SqueedBrewService
    {
        public string GetLocation()
        {
            string currentCountry = "Sweden";
            string currentCity = "Gothenburg";

            //return BuildString();
            return BuildString2(currentCity, currentCountry);

            //static string BuildString() => currentCity + ", " + currentCountry;
            static string BuildString2(string a, string b) => a + " ," + b;
        }
    }
}
