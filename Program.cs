Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());


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
