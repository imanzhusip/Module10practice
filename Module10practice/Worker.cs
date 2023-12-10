using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10practice
{
    class Worker : IWorker
    {
        public string Name { get; set; }

        public Worker(string name)
        {
            Name = name;
        }

        public void Build(IPart part)
        {
            Console.WriteLine($"{Name} строит {part.Name}");
        }
    }
}
