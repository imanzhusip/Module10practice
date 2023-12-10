using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10practice
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }

        public TeamLeader(string name)
        {
            Name = name;
        }

        public void Build(IPart part)
        {
            Console.WriteLine($"{Name} проверяет, что {part.Name} уже построено");
        }
    }

}
