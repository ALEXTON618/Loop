string nameActor = Console.ReadLine();
double startPoints = double.Parse(Console.ReadLine());
int countJury = int.Parse(Console.ReadLine());

double allPoints = startPoints;

for(int i = 1; i <= countJury; i++)
{
    string nameJury = Console.ReadLine();
    double pointsJury = double.Parse(Console.ReadLine());

    allPoints += nameJury.Length * pointsJury / 2;
    if(allPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {allPoints:F1}!");
        return;
    }

}
Console.WriteLine($"Sorry, {nameActor} you need {1250.5 - allPoints:F1} more!");

