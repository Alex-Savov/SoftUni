using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //•	Ако числото е до 100 включително, бонус точките са 5.
            //•	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //•	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

            double bonusPoints = 0;
            if (n <= 100)
            {
                bonusPoints = 5;
            }
            else if (n > 100 && n <= 1000)
            {
                bonusPoints = n * 0.2;
            }
            else
            {
                bonusPoints = n * 0.1;
            }

            //•	Допълнителни бонус точки(начисляват се отделно от предходните):
            //o За четно число  +1 т.
            //o За число, което завършва на 5  +2 т.
            if (n % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (n % 5 == 0)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + n);
        }
    }
}
