using System.Collections.Generic;
using System.Linq;

namespace FishTank
{
    public class Tank
    {
        public List<Fish> Fish;

        public Tank() 
        {
            Fish = new List<Fish>(); 
        }

        public double Feed()
        {
            return Fish.Sum(x => x.Food);
        }

        public void AddFish(Fish fish)
        {
            Fish.Add(fish);
        }
    }
}
