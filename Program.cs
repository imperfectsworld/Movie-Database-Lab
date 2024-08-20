using Movie_Database_Lab;
using System.ComponentModel.Design;
bool tryAgain = true;
List<String> menu = new List<String>();
List<Movie> movies = new List<Movie>()
{

    new Movie("Notorious BIG", "Drama"), new Movie("Wolf on Wallstreet", "Drama"), new Movie("Chuck and Larry", "Comedy"),
    new Movie("Borderlands", "Action"), new Movie("Deadpool", "Action"), new Movie("If", "Comedy"),
    new Movie("The Fall Guy", "Drama"), new Movie("Scoop", "Drama"), new Movie("Overlord", "Horror"),
    new Movie("Smile", "Horror"), new Movie("Mouse Trap", "Horror"), new Movie("Batman", "Action"),

};

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");
menu = Movie.ShowCategoryMenu();


while (tryAgain == true)
{
    Console.WriteLine($"Please choose a number between 1 and {menu.Count}.");
    int choice = Valid.GetInputBetween1and4();
    Movie.ShowMovies(choice, movies);
    tryAgain = Valid.GetContinue();
}
