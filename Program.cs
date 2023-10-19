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

Console.WriteLine($"3.Feladat: {sportagak.Count()}");

int arany = sportagak.Count(x => x.Helyezes == 1);
int ezust = sportagak.Count(x => x.Helyezes == 2);
int bronz = sportagak.Count(x => x.Helyezes == 3);

Console.WriteLine($"4.Feladat:");
Console.WriteLine($"\tArany: {arany}");
Console.WriteLine($"\tEzust: {ezust}");
Console.WriteLine($"\tBronz: {bronz}");
Console.WriteLine($"\tÖsszesen: {arany+ezust+bronz}");