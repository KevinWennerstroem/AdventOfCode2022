var sectionAssignments = await File.ReadAllLinesAsync(@"inventory\sectionAssignments.txt");

int pairs = 0;

foreach (var sectionAssignmentPair in sectionAssignments)
{
    var sectionAssignment = sectionAssignmentPair.Split(",");

    var start01 = Int32.Parse(sectionAssignment[0].Split("-")[0]);
    var start02 = Int32.Parse(sectionAssignment[1].Split("-")[0]);
    var end01 = Int32.Parse(sectionAssignment[0].Split("-")[1]);
    var end02 = Int32.Parse(sectionAssignment[1].Split("-")[1]);

    if (start01 >= start02 && start01 <= end02)
    {
        pairs++;
    }else if (start02 >= start01 && start02 <= end01)
    {
        pairs++;
    }
}

Console.WriteLine("Overlaped Pairs: " + pairs);