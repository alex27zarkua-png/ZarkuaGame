using System;
class Program
{
    //1 размер поля
    const int FieldWidth = 10;
    const int FieldHeight = 5;
    //2 параметры игры
    const int HeroDamage = 20;
    const int MonsterDamage = 10;
    const int HeroHealing = 20;
    const int MaxHealth = 100;
    static void Main()
    {
        int heroHealth = MaxHealth;
        int monsterHealth = 60;
        int heroX = 1;
        int heroY = 2;
        Console.WriteLine("=ИГРА:ПОДЗЕМЕЛЬЕ=");
        // 3выыод игрового поля
        for (int y = 0; y < FieldHeight; y++)
        {
            for (int x = 0; x < FieldWidth; x++)
            {
                if (x == heroX && y == heroY)
                    Console.Write("H ");
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }
        //4состояние персонажей
        Console.WriteLine();
        Console.WriteLine($"Здоровье героя: {heroHealth}");
        Console.WriteLine($"Здоровье дьявола: {monsterHealth}");
        //5ввод команды игрока
        Console.WriteLine();
        Console.WriteLine("1 - Атаковать");
        Console.WriteLine("2 - Восстановить здоровье");
        Console.WriteLine("0 - Выход");
        Console.Write("Твоя команда: ");
        string? command = Console.ReadLine();
        switch (command)
        {
            case "1":
                //6Уменьшаем здоровье монстра на величину урона
                monsterHealth -= HeroDamage;
                if (monsterHealth < 0)
                    monsterHealth = 0;
                Console.WriteLine($"Герой нанёс {HeroDamage} урона.");
                Console.WriteLine($"Здоровье монстра: {monsterHealth}");
                if (monsterHealth > 0)
                {
                    heroHealth -= MonsterDamage;
                    if (heroHealth < 0)
                        heroHealth = 0;
                    Console.WriteLine($"Монстр нанёс {MonsterDamage} урона.");
                    Console.WriteLine($"Здоровье героя: {heroHealth}");
                }
                else
                {
                    Console.WriteLine("Монстр побеждён!");
                }
                break;
            case "2":
                //7Здоровье не может превышать максимальное
                heroHealth += HeroHealing;
                if (heroHealth > MaxHealth)
                    heroHealth = MaxHealth;
                Console.WriteLine($"Здоровье героя: {heroHealth}");
                break;
            case "0":
                Console.WriteLine("Выход из игры.");
                break;
            default:
                Console.WriteLine("Неизвестная команда. Попробуй снова при следующем запуске.");
                break;
        }
    }
}