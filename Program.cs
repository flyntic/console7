/*
 Разработайте приложение «7 чудес света», где каждое 
чудо будет представлено отдельным классом. Создайте дополнительный класс, содержащий точку входа.
Распределите приложение по файлам проекта и с помощью пространства имён обеспечьте возможность 
взаимодействия классов
*/
namespace Console7;

class Program
{
 static void Main(string[] args)
 {
  PyramidOfCheops pyramidOfCheops = new PyramidOfCheops();
  pyramidOfCheops.PrintInfo();
  HangingGardensOfSemiramis hangingGardensOfSemiramis = new HangingGardensOfSemiramis();
  hangingGardensOfSemiramis.PrintInfo();
  StatueOfZeus statueOfZeus = new StatueOfZeus();
  statueOfZeus.PrintInfo();
  TempleOfArtemis templeOfArtemis = new TempleOfArtemis();
  templeOfArtemis.PrintInfo();
  Mausoleum mausoleum = new Mausoleum();
  mausoleum.PrintInfo();
  ColossusOfRhodes colossusOfRhodes = new ColossusOfRhodes();
  colossusOfRhodes.PrintInfo();
  LighthouseOfAlexandria lighthouseOfAlexandria = new LighthouseOfAlexandria();
  lighthouseOfAlexandria.PrintInfo();
 }
}