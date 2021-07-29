using Humanizer;
using System;
using System.Collections.Generic;

namespace CAFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var comments = new List<FBComment>
            {
                new FBComment
                {
                    Owner = "Issam A.",
                    Comment = "I Think ASP NET Core is the most powerfull Web Framework",
                    CreatedAt = new DateTime (2021, 01, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Reem S.",
                    Comment = "Personally I Prefere Using C# with it.",
                    CreatedAt = new DateTime(2021, 02, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Issam A.",
                    Comment = "Have you Tried Using Blazor?",
                    CreatedAt = new DateTime(2021, 06, 01, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Reem S.",
                    Comment = "Have you Tried Using Blazor?",
                    CreatedAt = new DateTime(2021, 06, 28, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Abeer B.",
                    Comment = "I Prefer VB over C#.",
                    CreatedAt = new DateTime(2021, 07, 11, 10, 30, 00)
                },
                new FBComment {
                    Owner = "Abeer B.",
                    Comment = "VB is not from C family languages, It's hard for me",
                    CreatedAt = DateTime.Now.AddMinutes(-5)
                }
            };

            foreach(var comment in comments)
                Console.WriteLine(comment);


            Console.ReadKey();
        }
    }

    class FBComment
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString() => $"{Owner} says: \n" +
                   $"\"{Comment}\"" +
                   $"\n\t\t\t\t {CreatedAt.Humanize()}";

        //public override string ToString() => $"{Owner} says: \n" +
        //          $"\"{Comment}\"" +
        //          $"\n\t\t\t\t {CreatedAt.ToString("yyyy-MM-dd hh:mm")}";
    }
}
