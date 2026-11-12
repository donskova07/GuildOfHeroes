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

yaroslav.Health -= 25;
yaroslav.Health -= 50;

if (yaroslav.Health < 0)
{
    yaroslav.Health = 0;
}

anastasia.Health -= 30;
anastasia.Health -= 50;

if (anastasia.Health < 0)
{
    anastasia.Health = 0;
}



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



Console.WriteLine();
Console.WriteLine(">>> Каталог игр <<<");

Game witcher = new Game("The Witcher 3", "RPG", 2015);
Game minecraft = new Game("Minecraft", "Sandbox", 2011);
Game cyberpunk = new Game("Cyberpunk 2077", "RPG", 2020);

witcher.Rating = 9.8;
minecraft.Rating = 9.5;

Console.WriteLine($"Название: {witcher.Title}, Жанр: {witcher.Genre}, Год: {witcher.ReleaseYear}, Рейтинг: {witcher.Rating}");
Console.WriteLine($"Название: {minecraft.Title}, Жанр: {minecraft.Genre}, Год: {minecraft.ReleaseYear}, Рейтинг: {minecraft.Rating}");
Console.WriteLine($"Название: {cyberpunk.Title}, Жанр: {cyberpunk.Genre}, Год: {cyberpunk.ReleaseYear}, Рейтинг: {cyberpunk.Rating}");