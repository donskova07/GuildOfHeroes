public class Game {
    public string Title;
    public string Genre;
    public int ReleaseYear;
    public double Rating;

    public Game(string title, string genre, int releaseYear) {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = 0.0;
    }
}