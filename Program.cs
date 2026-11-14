Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");


Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");
bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());


Console.WriteLine();
Console.WriteLine(">>> каталог игр <<<");

Game witcher = new Game("The Witcher 3", "RPG", 2015);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game cyberpunk = new Game("Cyberpunk 2077", "RPG", 2020);

witcher.Rating = 9.8;
minecraft.Rating = 9.5;

Console.WriteLine($"название: {witcher.Title}, жанр: {witcher.Genre}, год: {witcher.ReleaseYear}, рейтинг: {witcher.Rating}");
Console.WriteLine($"название: {minecraft.Title}, жанр: {minecraft.Genre}, год: {minecraft.ReleaseYear}, рейтинг: {minecraft.Rating}");
Console.WriteLine($"название: {cyberpunk.Title}, жанр: {cyberpunk.Genre}, год: {cyberpunk.ReleaseYear}, рейтинг: {cyberpunk.Rating}");


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

Console.WriteLine();
Console.WriteLine(witcher.GetInfo());
Console.WriteLine();
Console.WriteLine(minecraft.GetInfo());
Console.WriteLine();
Console.WriteLine(cyberpunk.GetInfo());
