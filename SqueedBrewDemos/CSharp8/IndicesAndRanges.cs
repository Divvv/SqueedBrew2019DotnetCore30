namespace SqueedBrewDemos
{
    public class IndicesAndRanges
    {
        System.Index _index = 4;
        System.Range _range = 0..9;
        readonly string[] words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };

        public void Stuff()
        {
            var secondLastItem = words[^2];
            var fifthItem = words[_index];

            var firstFiveItems = words[0..4];
            var firstTenItems = words[_range];
        }
    }


}
