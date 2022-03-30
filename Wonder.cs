namespace Console7;

public class Wonder
{
    protected static int id=0;
    public int WonderId { get; set; }
    public string Name { get; set; }
    public string Place { get; set; }
    public string Time { get; set; }
    public bool Exist { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine("---------------"+WonderId+"---------------");
        Console.WriteLine("Название чуда " + Name);
        Console.WriteLine("Время создания " + Time);
        Console.WriteLine("Местоположение " + Place);
        Console.WriteLine(Exist ? "Сохранился до нашего времени" : "Разрушен");
        Console.WriteLine("------------------------------");
    }

}