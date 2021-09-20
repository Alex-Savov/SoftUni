using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;
        public RandomList()
        {
            rnd = new Random();
        }
        public string RandomString()
        {
            int RandomIndex = rnd.Next(0, this.Count);
            string result = this[RandomIndex];
            this.RemoveAt(RandomIndex);
            return result;
        }
    }
}
