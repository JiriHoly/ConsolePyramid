int vyska = int.Parse(Console.ReadLine());
int sirka = vyska * 2 - 1;

// Vykresli prvni pulku
for (int radek = 0; radek < vyska ; radek++)
{
    int pocetHvezdicka = radek * 2 + 1;
    int pocetMinus = (sirka - pocetHvezdicka) / 2;
    
    VypisRadek(pocetMinus, pocetHvezdicka);
}

// Vykresli druhou pulku
for (int radek = vyska -2; radek >= 0; radek--)
{
    int pocetHvezdicka = radek * 2 + 1;
    int pocetMinus = (sirka - pocetHvezdicka) / 2;

    VypisRadek(pocetMinus, pocetHvezdicka);
}

// vypisuje radek
void VypisRadek(int pocetMinus, int pocetHvezdicka)
{
    for (int znak = 0; znak < sirka; znak++)
    {
        if (znak < pocetMinus || znak >= pocetMinus + pocetHvezdicka) Console.Write("-");
        else
        {
            if (znak < pocetMinus + 1 || znak >= pocetMinus + pocetHvezdicka - 1)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");
            Console.ResetColor();
        }
    }
    Console.WriteLine();
}


// Console.ReadLine();

