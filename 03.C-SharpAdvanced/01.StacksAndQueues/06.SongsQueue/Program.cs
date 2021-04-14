using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQ = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songsQ.Count > 0)
            { 
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    songsQ.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQ));
                }
                else
                {
                    string songName = command.Replace("Add ", "");

                    if (!IsElementInQuExist(songsQ, songName))
                    {
                        songsQ.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
            }

            Console.WriteLine("No more songs!" );
        }
       
        public static bool IsElementInQuExist(Queue<string> q, string element)
        {
            bool isExist = false;

            for (int i = 0; i < q.Count; i++)
            {
                string currentSong = q.Dequeue();

                if (currentSong == element)
                {
                    isExist = true;
                }

                q.Enqueue(currentSong);
            }

            return isExist;
        }
    }
}
