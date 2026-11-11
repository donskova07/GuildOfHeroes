Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

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