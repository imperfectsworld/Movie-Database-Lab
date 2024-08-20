using Movie_Database_Lab;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Movie_Database_Lab
{
    internal class Movie
    {
        //parameters
        public string Title { get; set; }
        public string Category { get; set; }

        //constructor

        public Movie (string _title, string _category)
        {

            Title = _title;
            Category = _category;
        }

        //methods

        public static List<string> ShowCategoryMenu()
        {
            List<string> categories = new List<string>();

            categories.Add("Action");
            categories.Add("Comedy");
            categories.Add("Drama");
            categories.Add("Horror");


            for (int m = 0; m < categories.Count; m++)
            {
                Console.WriteLine($"{m + 1}. {categories[m]}");
            }
            return categories;

        }


        public static void ShowMovies(int choice, List <Movie> movies)
        {
            
            List<Movie> result = new List<Movie>();

            if (choice == 1)
            {
                result = movies.Where(e => e.Category == "Action").ToList();
                Console.WriteLine($"These are all the movies in the Action Category");
            }

            else if (choice == 2)
            {
                result = movies.Where(e => e.Category == "Comedy").ToList();
                Console.WriteLine($"These are all the movies in the Comedy Category");
            }

            else if (choice == 3)
            {
               result = movies.Where(e => e.Category == "Drama").ToList();
                Console.WriteLine($"These are all the movies in the Drama Category");
            }

            else if (choice == 4)
            {
                result = movies.Where(e => e.Category == "Horror").ToList();
                Console.WriteLine($"These are all the movies in the Horror Category");
            }
            

            foreach (Movie m in result)
            {
                Console.WriteLine(m.Title);
            }
           

        }

       



    }
}


