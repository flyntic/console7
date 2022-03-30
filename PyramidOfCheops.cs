
//Пирамида Хеопса XXVI—XXIII век до н. э.	Гиза (Египет)	египтяне[5]	единственное из чудес, сохранившееся до наших дней	неизвестно

namespace Console7;

public class PyramidOfCheops:Wonder
{
    public PyramidOfCheops()
    {
        id++;
        WonderId = id;
        Name = "Пирамида Хеопса";
        Time = "XXVI—XXIII век до н. э.";
        Place = "Гиза (Египет)";
        Exist = true;
    }
}