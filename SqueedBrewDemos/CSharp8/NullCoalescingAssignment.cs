using System.Collections.Generic;

namespace SqueedBrewDemos
{
    public class NullCoalescingAssignment
    {
        private readonly List<int> defaultList = new List<int>();

        public void Stuff(List<int> listOfInts)
        {
            // if(listOfInts == null)
            // {
            //     listOfInts = new List<int>();
            // }

            listOfInts ??= defaultList; // only assigns if listOfInts is null

            int? someInt = null;
            listOfInts.Add(someInt ??= 1337);

            // listOfInts.Add(someInt ??= 31337);
            // listOfInts = [1337, 1337] !!!
        }
    }
}
