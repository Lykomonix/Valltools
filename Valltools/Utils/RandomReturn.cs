using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valltools.Utils
{
    internal class RandomReturn
    {
        private string[] ListRandom;
        public RandomReturn(string[] listRandom)
        {
            ListRandom = listRandom;
        }

        public string getOne()
        {
            var rnd = new Random();
            int num = rnd.Next(ListRandom.Length);
            return ListRandom[num];
        }
    }
}
