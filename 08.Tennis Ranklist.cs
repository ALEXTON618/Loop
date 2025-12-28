int numberTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());
int totalPoints = startingPoints;
int sumTournamentPoints = 0;
int winsCount = 0;

for (int i = 0;i < numberTournaments; i++)
{
    string result = Console.ReadLine();

    if(result == "W")
    {
        sumTournamentPoints += 2000;
        winsCount++;
    }
    else if (result == "F")
    {
        sumTournamentPoints += 1200;
    }
    else if (result == "SF")
    {
        sumTournamentPoints += 720;
    }
}

totalPoints += sumTournamentPoints;
int avaragePoints = sumTournamentPoints / numberTournaments;
double winPercentage = (winsCount * 100.0) / numberTournaments;

Console.WriteLine($"Final points: {totalPoints }");
Console.WriteLine($"Avarage points: {avaragePoints}");
Console.WriteLine($"{winPercentage:F2}%");