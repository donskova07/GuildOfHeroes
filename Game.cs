public class Game {
    public string Title { get; private set; }
    public string Genre { get; private set; }
    public int ReleaseYear { get; private set; }
    public double Rating { get; private set; }
    public int PlayHours { get; private set; }

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
