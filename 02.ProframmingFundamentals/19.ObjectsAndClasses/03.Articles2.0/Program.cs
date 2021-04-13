using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Article
    {
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Author = autor;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> library = new List<Article>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] articleData = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(articleData[0], articleData[1], articleData[2]);
                library.Add(article);
            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":
                    library = library.OrderBy(x => x.Title).ToList();
                    break;
                case "author":
                    library = library.OrderBy(x => x.Author).ToList();
                    break;
                case "content"
                : library = library.OrderBy(x => x.Content).ToList();
                    break;
                default:
                    break;
            }
            foreach (var article in library)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
