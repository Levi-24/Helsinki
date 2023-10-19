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
