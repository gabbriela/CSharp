using System.Collections.Generic;

namespace _08.MilitaryElite
{
    interface ILeutenantGeneral : IPrivate
    {
        List<Private> ListOfPrivates { get; set; }
    }
}
