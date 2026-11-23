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

List<Hero> members = guild.GetMembers();

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");

if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
}

Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}

Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
} else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}

Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

Hero? strongest = guild.FindStrongest();
if (strongest != null) {
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}



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
