//Статуя Зевса в Олимпии	435 г. до н. э.	Олимпия (Греция)	Фидий	V в.	сгорела в
//Константинополе во время пожара на Ипподроме в V в.	храмовая статуя в храме Зевса в Олимпии

namespace Console7;

public class StatueOfZeus:Wonder
{
    public StatueOfZeus()
    {
        id++;
        WonderId = id;
        Name = "Статуя Зевса в Олимпии";
        Time = "435 г. до н. э.";
        Place = "Олимпия (Греция)";
        Exist = false;
    }   
}