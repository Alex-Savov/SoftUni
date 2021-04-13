using System;

namespace _02.Articles
{
    class Article
    {
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Autor = autor;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAutor(string newAutor)
        {
            Autor = newAutor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(articleData[0], articleData[1], articleData[2]);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAutor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
