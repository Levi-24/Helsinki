using Helsinki;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

List<Sportag> sportagak = new List<Sportag>();
using (var sr = new StreamReader(@"..\..\..\src\helsinki.txt", Encoding.UTF8))
{
    while (!sr.EndOfStream)
    {
        sportagak.Add(new Sportag(sr.ReadLine()));
    }
}

Console.WriteLine($"3.Feladat:");
Console.WriteLine($"Pontszerző helyezések száma: {sportagak.Count()}");

int arany = sportagak.Count(x => x.Helyezes == 1);
int ezust = sportagak.Count(x => x.Helyezes == 2);
int bronz = sportagak.Count(x => x.Helyezes == 3);

Console.WriteLine($"4.Feladat:");
Console.WriteLine($"\tArany: {arany}");
Console.WriteLine($"\tEzust: {ezust}");
Console.WriteLine($"\tBronz: {bronz}");
Console.WriteLine($"\tÖsszesen: {arany+ezust+bronz}");

int negyedik = sportagak.Count(x => x.Helyezes == 4);
int otodik = sportagak.Count(x => x.Helyezes == 5);
int hatodik = sportagak.Count(x => x.Helyezes == 6);

int olimpiaiPontok = arany*7 + ezust*5 + bronz*4 + negyedik*3 + otodik*2 + hatodik;
Console.WriteLine("5.Feladat:");
Console.WriteLine($"\tOlimpiai pontok száma: {olimpiaiPontok}");

Console.WriteLine("6.Feladat:");
int tornaermek = sportagak.Count(x => x.SportagNeve == "torna" && x.Helyezes < 4);
int uszasermek = sportagak.Count(x => x.SportagNeve == "uszas" && x.Helyezes < 4);

if (tornaermek > uszasermek)
    Console.WriteLine("\tTorna sportagban szereztek tobb ermet.");
else if (tornaermek < uszasermek)
    Console.WriteLine("\tUszas sportagban szereztek tobb ermet.");
else
    Console.WriteLine("\tEgyenlo volt az ermek szama.");


int pont = 0;
using (var sw = new StreamWriter(@"..\..\..\src\helsinki2.txt", false, Encoding.UTF8))
{
    foreach (var sportag in sportagak)
    {
        sportag.SportagNeve = sportag.SportagNeve.Replace("kajakkenu", "kajak-kenu");
        switch (sportag.Helyezes)
        {
            case 1:
                pont = 7;
                break;
            case 2:
                pont = 5;
                break;
            case 3:
                pont = 4;
                break;
            case 4:
                pont = 3;
                break;
            case 5:
                pont = 2;
                break;
            case 6:
                pont = 1;
                break;
            default:
                break;
        }
        sw.WriteLine($"{sportag.Helyezes} {sportag.SportolokSzama} {pont} {sportag.SportagNeve} {sportag.VersenyszamNeve}");
    }
}

Console.WriteLine("8.Feladat:");
var legtobbSportolo = sportagak.Find(s => s.SportolokSzama == sportagak.Max(x => x.SportolokSzama));

Console.WriteLine("Helyezes: {0}", legtobbSportolo.Helyezes);
Console.WriteLine("Sportag: {0}", legtobbSportolo.SportagNeve);
Console.WriteLine("Versenyszam: {0}", legtobbSportolo.VersenyszamNeve);
Console.WriteLine("Sportolok szama: {0}", legtobbSportolo.SportolokSzama);