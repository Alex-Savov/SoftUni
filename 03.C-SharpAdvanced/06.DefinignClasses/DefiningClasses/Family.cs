using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> myFamily = new List<Person>();

        public void AddMember(Person member)
        {
            myFamily.Add(member);
        }

        public Person GetOldestMember()
        {
            int oldestMemberIndex = 0;
            int maxAge = int.MinValue;

            for (int i = 0; i < myFamily.Count; i++)
            {
                if (myFamily[i].Age > maxAge)
                {
                    maxAge = myFamily[i].Age;
                    oldestMemberIndex = i;
                }
            }

            return myFamily[oldestMemberIndex];
        }

        public void FilterMembersByAge(Func<int, bool> filter)
        {
            for (int i = 0; i < myFamily.Count; i++)
            {
                if (!filter(myFamily[i].Age))
                {
                    myFamily.RemoveAt(i);
                    i--;
                }
            }
        }

        public void OrderByName()
        {
            for (int i = 0; i < myFamily.Count; i++)
            {
                for (int j = 0; j < myFamily.Count - 1; j++)
                {
                    string firstName = myFamily[j].Name.ToLower();
                    string seconName = myFamily[j + 1].Name.ToLower();

                    if (firstName.Length > seconName.Length)
                    {
                        Person temp = myFamily[j];
                        myFamily[j] = myFamily[j + 1];
                        myFamily[j + 1] = temp;
                    }

                    firstName = myFamily[j].Name.ToLower();
                    seconName = myFamily[j + 1].Name.ToLower();

                    int maxIndex = Math.Min(firstName.Length, seconName.Length);

                    for (int k = 0; k < maxIndex; k++)
                    {
                        if (firstName[k] > seconName[k])
                        {
                            string tempName = myFamily[j].Name;
                            int tempAge = myFamily[j].Age;

                            myFamily[j].Name = myFamily[j + 1].Name;
                            myFamily[j].Age = myFamily[j + 1].Age;
                            myFamily[j + 1].Name = tempName;
                            myFamily[j + 1].Age = tempAge;
                            break;
                        }
                        else if (firstName[k] < seconName[k])
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void PrintMembers(string pattern)
        {
            string[] patternTokens = pattern
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] patternTokensIgnoreCase = pattern
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(x => x.ToLower())
              .ToArray();

            int nameIndex = Array.IndexOf(patternTokensIgnoreCase, "member.name");
            int ageIndex = Array.IndexOf(patternTokensIgnoreCase, "member.age");

            
            foreach (var member in myFamily)
            {
                string name = member.Name;
                string age = member.Age.ToString();
                patternTokens[nameIndex] = name;
                patternTokens[ageIndex] = age;

                Console.WriteLine(string.Join(' ', patternTokens));
            }
        }
    }
}
