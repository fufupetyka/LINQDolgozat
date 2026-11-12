using Dolgozat;

List<Games> Jatekok = [];

#nullable disable
#region file beolvas
const string FilePath = "..\\..\\..\\data\\videogames.csv";
using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream) 
{
    var db = sr.ReadLine().Split(',');
    Jatekok.Add(new()
    {
        Cim = db[0],
        Mufaj = db[1],
        KiadasDatum = Convert.ToDateTime(db[2]),
        AktivJatekosok = int.Parse(db[3]),
        Ertekeles = float.Parse(db[4].Replace('.', ',')),
    });
}
#endregion

//1.Feladat
var f1 = Jatekok.Where(p => p.Ertekeles > 4.5).Count();
Console.WriteLine($"nagyobb mint 4.5: {f1}");
//2.feladat
var f2 = Jatekok.MaxBy(p => p.AktivJatekosok).Cim;
Console.WriteLine($"A játék címe amivel a legtöbben játszanak: {f2}");
//3.feladat
var f3 = Jatekok.Where(p => p.KiadasDatum.Year < 2020);
//4.feladat
var f4 = Jatekok.Average(p => p.Ertekeles);
Console.WriteLine($"A játékok átlag értékelése: {f4}");
//5.feladat
var f5 = Jatekok.Where(p => p.Cim == "Cyber City 2077");
Console.WriteLine($"Játék : {f5}");
//6.feladat
var f6 = Jatekok.Where(p => p.Mufaj == "RPG").OrderByDescending(p => p.KiadasDatum);
foreach (var j in f6) 
{
    Console.WriteLine($"{j.Cim}\n");
}
//7.feladat
var f7 = Jatekok.Where(p => p.Ertekeles > 0).OrderByDescending(p => p.Ertekeles).Take(3);
Console.WriteLine($"top 3 értékelt játék: {f7}");
//8.feladat
var f8 = Jatekok.Where(p => p.KiadasDatum.Year >= 2022).Average(p => p.AktivJatekosok);
