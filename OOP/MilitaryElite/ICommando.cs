using System.Collections.Generic;

namespace _08.MilitaryElite
{
    interface ICommando 
    {
        Dictionary<string, string> Missions { get; set; }

        void CompleteMission();
    }
}
