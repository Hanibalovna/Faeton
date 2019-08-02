using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    enum Janre
    {
        Professional
    }
    struct Book
    {
        public string Author;
        public int PageCount;
        public Janre Janre;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Author = "Jeffrey Richter",
                PageCount = 123456,
                Janre = Janre.Professional
            };

            Console.WriteLine("Enter all books(Author= , Pages= , Janre= ;...)");
            string bookStr = Console.ReadLine();

            int count = 1;
            for (int i = 0; i < bookStr.Length; i++)
            {
                if (bookStr[i] == ';')
                {
                    count++;
                }
            }

            string[] parts = new string[count];
            int j = 0;
            for (int i = 0; i < bookStr.Length; i++)
            {
                if (bookStr[i] != ';')
                    parts[j] += bookStr[i];
                else
                    j++;
            }
            Book b2;
            for (int i = 0; i < count; i++)
            {
                string word = "";
                bool symbolAppeared = false;

                for (int k = 0; k < parts[i].Length; k++)
                {
                    if (symbolAppeared)
                        word += parts[i][j];
                    if (parts[i][k] == '=')
                        symbolAppeared = true;
                }

                switch (i)
                {
                    case 0:
                        b2.Author = word;
                        break;
                    case 1:
                        b2.PageCount = int.Parse(word);
                        break;
                    case 2:
                        b2.Janre = (Janre)int.Parse(word);
                        break;
                }
            }
        }
    }
}