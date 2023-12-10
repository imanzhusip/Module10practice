using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10practice
{
    class House
    {
        public List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Дом готов:");
            foreach (var part in parts)
            {
                Console.WriteLine(part.Name);
            }
        }
    }

}
