using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Heroes
    {
        public IEnumerable<string> SuperHeroes()
        {
            yield return "Thor";
            yield return "Hulk";
            yield return "Luke Cage";
            yield return "Wolverine";
            yield return "Starfire";
            yield return "Cyborg";
            yield return "Raven";
            yield return "Beast Boy";
            yield return "Robin";
        }
    }
}
