using lab4;
Monster<int>[] monsters = new Monster<int>[4];
for (int i = 0; i < monsters.Length; i++)
{
    Console.WriteLine("Введите имя:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите жизни:");
    int life = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите идентификатор:");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите боезапас:");
    int ammo = int.Parse(Console.ReadLine());
    monsters[i]=new Monster<int>(name, life, id, ammo);
}
Array.Sort(monsters);
foreach (var item in monsters)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Array.Sort(monsters, new SortByAmmo());
foreach (var item in monsters)
{
    Console.WriteLine(item);
}