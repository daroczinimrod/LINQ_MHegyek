using LINQ_MHegyek;


List<Hegyek> Hegyek = new List<Hegyek>();


StreamReader olvas = new StreamReader("hegyekMo.txt");
olvas.ReadLine();
while (!olvas.EndOfStream)
{
    string[] adat = olvas.ReadLine().Split(';');
    Hegyek.Add(new Hegyek(adat[0], adat[1], int.Parse(adat[2])));
}
olvas.Close();

Console.WriteLine($"3.Feladat : Hegycsucsok száma:  { Hegyek.Count()} db");
Console.WriteLine($"4.Feladat : Hegycsucsok atlagos magassaga: {Math.Round(Hegyek.Average(x => x.Magassag), 2)} m");
