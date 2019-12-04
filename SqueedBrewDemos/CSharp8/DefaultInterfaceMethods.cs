using System.Collections.Generic;

namespace SqueedBrewDemos
{
    public interface ISqueedBrewService
    {
        abstract string GetAddress();
        
        abstract IEnumerable<string> GetSpeakerNames();

        virtual public string Pepp() => "Nu kör vi Squeedbrew!!!!";
    }
}
