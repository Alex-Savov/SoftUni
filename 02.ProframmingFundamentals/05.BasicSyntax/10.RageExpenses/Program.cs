using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	On the first input line - lost games count – integer in the range[0, 1000].
            //•	On the second line – headset price -floating point number in range[0, 1000].
            //•	On the third line – mouse price -floating point number in range[0, 1000].
            //•	On the fourth line – keyboard price -floating point number in range[0, 1000].
            //•	On the fifth line – display price -floating point number in range[0, 1000].

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCounter++;
                }

                if (i % 3 == 0)
                {
                    mouseCounter++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCounter++;
                }
            }

            int displayCounter = 0;

            if (keyboardCounter != 0)
            {
                displayCounter = keyboardCounter / 2;
            }

            headsetPrice *= headsetCounter;
            mousePrice *= mouseCounter;
            keyboardPrice *= keyboardCounter;
            displayPrice *= displayCounter;

            double finalSum = headsetPrice
                            + mousePrice
                            + keyboardPrice
                            + displayPrice;

            Console.WriteLine($"Rage expenses: {finalSum:f2} lv.");
        }
    }
}
