public class GameLibrary {
    private List<Game> _games = new List<Game>();

    public int Count {
        get { return _games.Count; }
    }

    public bool AddGame(Game game) {
        if (FindGameByTitle(game.Title) != null) {
            return false;
        }

        _games.Add(game);
        return true;
    }

    public Game? FindGameByTitle(string title) {
        if (string.IsNullOrWhiteSpace(title)) {
            return null;
        }

        string searchTitle = title.Trim();

        foreach (Game game in _games) {
            if (string.Equals(game.Title, searchTitle, StringComparison.OrdinalIgnoreCase)) {
                return game;
            }
        }

        return null;
    }

    public bool RemoveGame(string title) {
        Game? game = FindGameByTitle(title);
        if (game == null) {
            return false;
        }

        _games.Remove(game);
        return true;
    }

    public List<Game> GetGames() {
        List<Game> result = new List<Game>();
        foreach (Game game in _games) {
            result.Add(game);
        }
        return result;
    }

    public int CountLongGames(int minimumHours) {
        int count = 0;

        foreach (Game game in _games) {
            if (game.PlayHours >= minimumHours) {
                count += 1;
            }
        }

        return count;
    }
}
