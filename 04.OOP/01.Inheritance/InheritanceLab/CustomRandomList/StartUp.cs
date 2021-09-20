using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rndList = new RandomList();
            rndList.Add("pesho");
            rndList.Add("gosho");
            rndList.Add("ivan");
            rndList.Add("dragan");
            rndList.Add("petkan");
            rndList.Add("osman");

            while (rndList.Count > 0)
            {
                Console.WriteLine(rndList.RandomString());
            }
        }
    }
}
