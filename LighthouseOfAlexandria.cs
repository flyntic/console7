//Александрийский маяк	303 г. до н. э.	Александрия Египетская	греки, династия Птолемеев	XIV в.	землетрясение	Для судоходства.

namespace Console7;

public class LighthouseOfAlexandria:Wonder
{
    public  LighthouseOfAlexandria()
    {
        id++;
        WonderId = id;
        Name = "Александрийский маяк";
        Time = "303 г. до н. э.";
        Place = "Александрия Египетская";
        Exist = false;
    }   
}