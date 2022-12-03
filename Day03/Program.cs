var rucksacks = await File.ReadAllLinesAsync(@"inventory\rucksack.txt");

int prioSum = 0;

foreach (var rucksack in rucksacks)
{
    var firstItem = rucksack.Substring(0, rucksack.Length/2);
    var secondItem = rucksack.Substring(rucksack.Length/2);

    foreach (var character in firstItem)
    {
        if (secondItem.Contains(character))
        {
            prioSum += GetIndex(character);
            break;
        }
    }
}

int groupSum = 0;

for (int r = 0; r < rucksacks.Length; r+=3)
{
    foreach (var character in rucksacks[r])
    {
        if(rucksacks[r+1].Contains(character) && rucksacks[r+2].Contains(character))
        {
            groupSum += GetIndex(character);
            break;
        }
    }
}

Console.WriteLine("Priorities Sum: " + prioSum);
Console.WriteLine("Group Sum: " + groupSum);

Console.Read();

int GetIndex(char character)
{
    int index = 1;
    if (Char.IsLower(character))
    {
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (i == character)
                break;
            else
                index++;
        }
    }else
    {
        index += 26;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            if (i == character)
                break;
            else
                index++;
        }
    }

    return index;
}