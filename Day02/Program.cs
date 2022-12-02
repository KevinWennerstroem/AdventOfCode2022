var strategy = await File.ReadAllLinesAsync(@"inventory\plan.txt");

int points = 0;

foreach (var item in strategy)
{
    var choose = item.Split(" ");

    if (choose[1] == "X")
    {
        switch (choose[0])
        {
            case "A":
                points += 3;
                break;
            case "B":
                points += 1;
                break;
            case "C":
                points += 2;
                break;
        }
    }else if (choose[1] == "Y")
    {
        points += 3;
        switch (choose[0])
        {
            case "A":
                points += 1;
                break;
            case "B":
                points += 2;
                break;
            case "C":
                points += 3;
                break;
        }
    }else if (choose[1] == "Z")
    {
        points += 6;
        switch (choose[0])
        {
            case "A":
                points += 2;
                break;
            case "B":
                points += 3;
                break;
            case "C":
                points += 1;
                break;
        }
    }
}

Console.WriteLine("Points: " + points);

Console.Read();