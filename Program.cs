// Probe.Run();

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());





Console.WriteLine();
Console.WriteLine(">>> каталог игр <<<");

Game witcher = new Game("The Witcher 3", "RPG", 2015);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game cyberpunk = new Game("Cyberpunk 2077", "RPG", 2020);

witcher.UpdateRating(9.8);
minecraft.UpdateRating(9.5);

GameLibrary library = new GameLibrary();

Console.WriteLine($"приём Witcher 3: {library.AddGame(witcher)}");
Console.WriteLine($"приём Minecraft: {library.AddGame(minecraft)}");
Console.WriteLine($"приём Cyberpunk 2077: {library.AddGame(cyberpunk)}");

List<Game> games = library.GetGames();

if (games.Count > 0) {
    Console.WriteLine($"игр в каталоге: {library.Count}");
    Console.WriteLine($"первая: {games[0].Title}");
    Console.WriteLine($"последняя: {games[games.Count - 1].Title}");
}

Console.WriteLine();
foreach (Game game in games) {
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine(">>> проверка действий <<<");

Console.WriteLine($"рейтинг Cyberpunk до изменений: {cyberpunk.Rating}");
cyberpunk.UpdateRating(8.7);
Console.WriteLine($"после допустимого вызова: {cyberpunk.Rating}");
cyberpunk.UpdateRating(25.0);
Console.WriteLine($"после неверного вызова: {cyberpunk.Rating}");

witcher.AddPlayHours(120);
witcher.AddPlayHours(-5);
Console.WriteLine($"часы в Witcher 3: {witcher.PlayHours}");

Console.WriteLine($"Witcher 3 высоко оценён: {witcher.IsHighlyRated()}");
Console.WriteLine($"Cyberpunk 2077 высоко оценён: {cyberpunk.IsHighlyRated()}");

minecraft.AddPlayHours(40);
Console.WriteLine($"часы в Minecraft: {minecraft.PlayHours}, в Witcher 3 по прежнему: {witcher.PlayHours}");

Game? foundGame = library.FindGameByTitle(" cYbErPuNk 2077 ");
if (foundGame != null) {
    Console.WriteLine($"найден по запросу « cYbErPuNk 2077 »: {foundGame.Title}");
    foundGame.AddPlayHours(50);
    Console.WriteLine($"наиграно в Cyberpunk 2077 через поиск: {cyberpunk.PlayHours}");
} else {
    Console.WriteLine("по запросу « cYbErPuNk 2077 » никого нет.");
}

Game? missing = library.FindGameByTitle("Doom");
if (missing != null) {
    Console.WriteLine($"найден: {missing.Title}");
} else {
    Console.WriteLine("по запросу «Doom» никого нет.");
}

Console.WriteLine($"повтор Minecraft принят: {library.AddGame(minecraft)}");
Console.WriteLine($"после добавления четвёртой игры: {library.AddGame(new Game("Roblox", "Sandbox", 2006))}, игр: {library.Count}");

Console.WriteLine($"игры больше 100 часов: {library.CountLongGames(100)}");

Console.WriteLine($"удалён отсутствующий: {library.RemoveGame("Doom")}");
Console.WriteLine($"удалён Roblox: {library.RemoveGame(" roblox ")}");
Console.WriteLine($"игр после удалений: {library.Count}");

Console.WriteLine();
foreach (Game game in library.GetGames()) {
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(">>> игровая сессия <<<");

PlaySession playthrough = new PlaySession(501, "Прохождение The Witcher 3", 9.0, 120);
Console.WriteLine($"№{playthrough.Id}: {playthrough.Title}");

Console.WriteLine($"старт на Cyberpunk 2077 (рейтинг {cyberpunk.Rating}): {playthrough.TryStart(cyberpunk)}");
Console.WriteLine(playthrough.GetInfo());

Console.WriteLine($"старт на Witcher 3 (рейтинг {witcher.Rating}): {playthrough.TryStart(witcher)}");
Console.WriteLine($"часы в Witcher 3 до завершения: {witcher.PlayHours}");

Console.WriteLine($"завершение сессии: {playthrough.TryFinish()}");
Console.WriteLine($"часы в Witcher 3 после завершения: {witcher.PlayHours}");

Console.WriteLine($"повторное завершение: {playthrough.TryFinish()}");
Console.WriteLine($"часы после повтора: {witcher.PlayHours}");

Game? foundWitcher = library.FindGameByTitle(" wItChEr 3 ");
if (foundWitcher != null) {
    Console.WriteLine($"часы у Witcher 3 из каталога: {foundWitcher.PlayHours}");
}
Console.WriteLine(playthrough.GetInfo());
