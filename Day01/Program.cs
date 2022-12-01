var input = await File.ReadAllTextAsync(@"inventory\calories.txt");

var elveLists = input.Split("\r\n\r\n");

var elveCalories = new int[elveLists.Length];

for (int i = 0; i < elveLists.Length; i++)
{
    var sum = 0;
    foreach(var item in elveLists[i].Split("\r\n"))
    {
        sum += Int32.Parse(item);
    }
    elveCalories[i] = sum;
}

int first = 0, second = 0, third = 0;

foreach(var item in elveCalories)
{
    if (item > first)
    {
        second = first;
        first = item;
    }else if (item > second)
    {
        third = second;
        second = item;
    }else if (item > third)
    {
        third = item;
    }
}

var top3Sum = first + second + third;

Console.WriteLine("Elve with the most calories: " + first);
Console.WriteLine("Top 3 Eleves in sum: " + top3Sum);


Console.Read();