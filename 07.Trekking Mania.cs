int group = int.Parse(Console.ReadLine());


int countMusala = 0;
int countMonblan = 0;
int countKilimandjaro = 0;
int countK2 = 0;
int countEverest = 0;

int totalPeople = 0;

for (int i = 1; i <= group; i++)
{
    int countPeople = int.Parse(Console.ReadLine());

    totalPeople += countPeople;

    if(countPeople < 6)
    {
        countMusala += countPeople;
    }
    else if(countPeople < 13)
    {
        countMonblan += countPeople;

    }
    else if (countPeople < 26)
    {
        countKilimandjaro += countPeople;
    }
    else if (countPeople < 41)
    {
        countK2 += countPeople;
    }
    else  
    {
        countEverest += countPeople;
        
    }
}
Console.WriteLine($"{countMusala * 1.0 / totalPeople * 100:F2}%");
Console.WriteLine($"{countMonblan * 1.0 / totalPeople * 100:F2}%");
Console.WriteLine($"{countKilimandjaro * 1.0 / totalPeople * 100:F2}%");
Console.WriteLine($"{countK2 * 1.0 / totalPeople * 100:F2}%");
Console.WriteLine($"{countEverest * 1.0 / totalPeople * 100:F2}%");