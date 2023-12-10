using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10practice
{
   
        class Program
        {
            static void Main()
            {
                House house = new House();
                Team team = new Team(
                    new Worker("Строитель 1"),
                    new Worker("Строитель 2"),
                    new Worker("Строитель 3"),
                    new Worker("Строитель 4"),
                    new TeamLeader("Бригадир")
                );

                team.Work(house);
                house.Show();

                Console.ReadKey();
            }
        }
    
}
