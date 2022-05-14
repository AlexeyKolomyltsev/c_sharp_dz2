///Дано число обозначающее день недели. Выяснить является номер дня недели выходным

var week = new Dictionary<string, string>() /// Добавил словарь с днями недели
{
    {"1", "понедельник"},
    {"2", "вторник"},
    {"3", "среда"},
    {"4", "четверг"},
    {"5", "пятница"},
    {"6", "суббота"},
    {"7", "воскресенье"},
};

Console.WriteLine("Ввести день недели");
string day = Console.ReadLine();
if (week.TryGetValue(day, out string value)) ///Проверка наличия номера дня недели
{
    if (day == "6" || day == "7")
    {
        Console.WriteLine($"{day} день недели выходной - {value}");;
    }
    else Console.WriteLine($"{day} день недели будний - {value}");
}
else Console.WriteLine("Нет такого дня недели");

