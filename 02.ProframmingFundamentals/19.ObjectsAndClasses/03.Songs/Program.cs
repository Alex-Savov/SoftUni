using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);

                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(x => x.TypeList == command))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
