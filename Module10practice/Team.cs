using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10practice
{
    class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public Team(params IWorker[] teamMembers)
        {
            workers.AddRange(teamMembers);
        }

        public void Work(House house)
        {
            foreach (var part in house.parts)
            {
                foreach (var worker in workers)
                {
                    worker.Build(part);
                }
            }
        }
    }
}
