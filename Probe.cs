public static class Probe {
    public static void Run() {
    Console.WriteLine(">>> Проба <<<");
Guild probeGuild = new Guild("Учебная гильдия");
    Hero weak = new Hero("Слабый", 80);
    Hero tired = new Hero("Уставший", 110);
    probeGuild.AddHero(weak);
    probeGuild.AddHero(tired);

    QuestBoard probeBoard = new QuestBoard(probeGuild);
    Quest probeQuest = new Quest(201, "Учебное дело", 100, 30);
    probeBoard.AddQuest(probeQuest);

    Console.WriteLine($"Нет поручения: {probeBoard.TryAssign(999, "Уставший")}");
    Console.WriteLine($"Нет героя: {probeBoard.TryAssign(201, "Отсутствующий")}");
    Console.WriteLine($"Мало здоровья: {probeBoard.TryAssign(201, "Слабый")}");
    Console.WriteLine($"Закрыть без исполнителя: {probeBoard.TryComplete(201)}");

    Console.WriteLine($"Назначить уставшего: {probeBoard.TryAssign(201, "Уставший")}");
    tired.TakeDamage(20);
    Console.WriteLine($"Закрыть после урона: {probeBoard.TryComplete(201)}");
    Console.WriteLine($"Опыт: {tired.Experience}, выполнено: {probeQuest.IsCompleted}");

    Console.WriteLine($"Повтор номера: {probeBoard.AddQuest(new Quest(201, "Другое", 0, 5))}");
}
}

