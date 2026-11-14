public class Game {
    public string Title;
    public string Genre;
    public int ReleaseYear;
    public double Rating;
    public int PlayHours;

    public Game(string title, string genre, int releaseYear) {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = 0.0;
        PlayHours = 0;
    }

   
    public void UpdateRating(double newRating) {
        if (newRating < 0 || newRating > 10) {
            return;
        }

        Rating = newRating;
    }

  
    public void AddPlayHours(int hours) {
        if (hours <= 0) {
            return;
        }

        PlayHours += hours;
    }

   
    public bool IsHighlyRated() {
        return Rating >= 9.0;
    }

    
    public string GetInfo() {
        return $">>> {Title} <<<\n" +
               $"жанр: {Genre}\n" +
               $"год выпуска: {ReleaseYear}\n" +
               $"рейтинг: {Rating}\n" +
               $"наиграно часов: {PlayHours}";
    }
}
