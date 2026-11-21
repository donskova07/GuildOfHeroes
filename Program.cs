// Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.Heroes.Add(yaroslav);
guild.Heroes.Add(anastasia);
guild.Heroes.Add(artem);
guild.Heroes.Add(alexander);
guild.Heroes.Add(sergey);

Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.Heroes.Count}");
if (guild.Heroes.Count > 0) {
    Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
    Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in guild.Heroes) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}



// alexander.Health = 5000;
// Console.WriteLine($"После прямой записи: {alexander.Health}");

// alexander.Health = -100;
// Console.WriteLine($"После второй записи: {alexander.Health}");


Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");

// Hero spacedProbe = new Hero("   Александр   ", 150);
// Hero emptyProbe = new Hero("   ", 100);

// Console.WriteLine($"Имя с пробелами: [{spacedProbe.Name}]");
// Console.WriteLine($"Пустая запись: [{emptyProbe.Name}]");
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(-10);
// yaroslav.GainExperience(2147483647);
// Console.WriteLine($"После проверок опыта: {yaroslav.Experience}");
int strongCount = 0;
foreach (Hero hero in guild.Heroes) {
    if (hero.Health >= 120) {
        strongCount += 1;
    }
}
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");

if (guild.Heroes.Count > 0) {
    Hero strongest = guild.Heroes[0];
    foreach (Hero hero in guild.Heroes) {
        if (hero.Health > strongest.Health) {
            strongest = hero;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}



Console.WriteLine();
Console.WriteLine(">>> каталог игр <<<");

Game witcher = new Game("The Witcher 3", "RPG", 2015);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game cyberpunk = new Game("Cyberpunk 2077", "RPG", 2020);

witcher.UpdateRating(9.8);
minecraft.UpdateRating(9.5);
List<Game> library = new List<Game>();

library.Add(witcher);
library.Add(minecraft);
library.Add(cyberpunk);

if (library.Count > 0) {
    Console.WriteLine($"игр в каталоге: {library.Count}");
    Console.WriteLine($"первая: {library[0].Title}");
    Console.WriteLine($"последняя: {library[library.Count - 1].Title}");
}


Console.WriteLine();
foreach (Game game in library) {
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

library.Add(new Game("Roblox", "Sandbox", 2006));
Console.WriteLine($"после добавления четвёртой игры: {library.Count}");
int longGames = 0;
foreach (Game game in library) {
    if (game.PlayHours > 100) {
        longGames += 1;
    }
}
Console.WriteLine($"игры больше 100 часов: {longGames}");
cyberpunk.AddPlayHours(50);
Console.WriteLine($"наиграно в Cyberpunk 2077 через список: {library[2].PlayHours}");

Console.WriteLine();
foreach (Game game in library) {
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine(witcher.GetInfo());
Console.WriteLine();
Console.WriteLine(minecraft.GetInfo());
Console.WriteLine();
Console.WriteLine(cyberpunk.GetInfo());
