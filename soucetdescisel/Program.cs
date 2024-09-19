class Program
{
    static void Main()
    {
        Console.WriteLine("zadej 1. desetinné číslo:");
        float cislo1 = float.Parse(Console.ReadLine());

        Console.WriteLine("zadej 2. desetinné číslo:");
        float cislo2 = float.Parse(Console.ReadLine());

        float soucet = SoucetDesetinneCisla(cislo1, cislo2);
        Console.WriteLine("Součet čísel je: " + soucet);
    }

    static float SoucetDesetinneCisla(float a, float b)
    {
        return a + b;
    }
}