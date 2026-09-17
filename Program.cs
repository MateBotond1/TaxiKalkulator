Console.WriteLine("Utas neve:");
string Utasnev = Console.ReadLine();
Console.WriteLine("Megtett táv:");
int Tav = int.Parse(Console.ReadLine());
Console.WriteLine("Éjszakai utazás(Igen v. Nem):");
string Ejszaka = Console.ReadLine();
Console.WriteLine("Alapdíj:");
int alapdij = int.Parse(Console.ReadLine());
Console.WriteLine("Km díj:");
int Kmdij = int.Parse(Console.ReadLine());
Console.WriteLine("Éjszakai pótlék szorzója:");
double ejszpot = double.Parse(Console.ReadLine());
double ossz = alapdij + (Tav * Kmdij);
bool ejsz = false;
double osszesen = ossz;
if  (Ejszaka=="Igen" ||Ejszaka=="igen")
{
    ejsz=true;
    osszesen =ossz* (1+ejszpot);
}
Console.WriteLine("--------ÖSSZEGZÉS---------");
Console.Write("Utas neve:");
Console.WriteLine($"{Utasnev}");
Console.Write("Megtett táv:");
Console.WriteLine($"{Tav} km");
Console.Write("Alapérték:");
Console.WriteLine($"{ossz} Ft");
Console.Write("Fizetendő végösszeg:");
Console.WriteLine($"{osszesen} Ft");
Console.Write("Státusz:");
Console.WriteLine($"{ejszpot*100}% éjszakai pótlék felszámolva.");