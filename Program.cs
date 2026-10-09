namespace Zadanie_5_Raport_z_Walki;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Zadanie 5 Raport z Walki");
        Console.WriteLine("");
        
        Console.Write("Podaj imie bohatera: ");
        string imieBohatera = Console.ReadLine();        
        
        Console.Write("Maksymalne Punkty Zycia: ");
        int MaxZycie = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj aktualne zycie Bohatera: ");
        int aktualneZycieBohatera = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj podstawowe obrazenia Broni: ");
        int podstawoweObrazenia = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj premie do sily (Dodaje sie do ataku): ");
        int podstawowePremieDoSily = int.Parse(Console.ReadLine());
        
        Console.Write("Podaj mnozik ataku specjalnego: ");
        double mnozikataku = double.Parse(Console.ReadLine());
        
        Console.Write("Podaj Liczbe podstawowych atakow: ");
        int liczbaPodAtakowe = int.Parse(Console.ReadLine());


        double atakSpecjalny = mnozikataku*podstawoweObrazenia;
        double laczneObrazenia = liczbaPodAtakowe * (podstawoweObrazenia + podstawowePremieDoSily) + atakSpecjalny;
        
        
        bool pelneZycie = false;
        bool zyje = true;
        
        Console.WriteLine("========== RAPORT Z WALKI ==========");
        Console.WriteLine("Bohater: "+ imieBohatera);
        Console.WriteLine("Zdrowie: "+ aktualneZycieBohatera+"/"+MaxZycie +" ("+aktualneZycieBohatera*100/MaxZycie+"% )");
        Console.WriteLine("Zwykly atak: "+ podstawoweObrazenia);
        Console.WriteLine("Atak Specjalny: "+atakSpecjalny);
        Console.WriteLine("Laczne zadane obrazenia: "+laczneObrazenia );
        if(aktualneZycieBohatera<=0)
            zyje = false;
        else if(aktualneZycieBohatera > 0)
            zyje = true;
        Console.WriteLine("Zyje: "+zyje);
        
        if(aktualneZycieBohatera== MaxZycie)
            pelneZycie = true;
        else if(aktualneZycieBohatera<MaxZycie)
            pelneZycie = false;
        
        Console.WriteLine("Pelne Zycie: "+pelneZycie);
        Console.WriteLine("====================================");
        
        
        
    }
}