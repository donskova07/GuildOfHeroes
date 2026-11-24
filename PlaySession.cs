public class PlaySession {
    public int Id { get; private set; }
    public string Title { get; private set; }
    public double MinRating { get; private set; }
    public int PlannedHours { get; private set; }
    public Game? LinkedGame { get; private set; }
    public bool IsCompleted { get; private set; }

    public PlaySession(int id, string title, double minRating, int plannedHours) {
        Id = id;

        if (string.IsNullOrWhiteSpace(title)) {
            Title = "Безымянная сессия";
        } else {
            Title = title.Trim();
        }

        MinRating = minRating;
        if (MinRating < 0) {
            MinRating = 0;
        }

        PlannedHours = plannedHours;
        if (PlannedHours < 1) {
            PlannedHours = 1;
        }

        LinkedGame = null;
        IsCompleted = false;
    }

    public bool TryStart(Game game) {
        if (IsCompleted) {
            return false;
        }
        if (LinkedGame != null) {
            return false;
        }
        if (game.Rating < MinRating) {
            return false;
        }

        LinkedGame = game;
        return true;
    }

    public bool TryFinish() {
        if (IsCompleted) {
            return false;
        }

        Game? game = LinkedGame;
        if (game == null) {
            return false;
        }

        game.AddPlayHours(PlannedHours);
        IsCompleted = true;
        return true;
    }

    public string GetInfo() {
        string gameText = "не начата";
        if (LinkedGame != null) {
            gameText = LinkedGame.Title;
        }

        string doneText = "нет";
        if (IsCompleted) {
            doneText = "да";
        }

        return $"№{Id} «{Title}»: игра {gameText}, выполнено: {doneText}";
    }
}
