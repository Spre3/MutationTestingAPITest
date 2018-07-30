using System.Collections;
using System.Collections.Generic;
using HumanTesting;

namespace MutantTesting
{
    public class Mutant
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public int Age { get; set; }
        public IList<string> Abilities { get; set; }

        public bool CanCommunicateWithHuman(Human human)
        {
            return human.Language == Language && Age >= human.Age;
        }
    }
}
