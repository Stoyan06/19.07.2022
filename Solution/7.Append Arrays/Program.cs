string input = Console.ReadLine();
List<string> arrays = input.Split("|").ToList();
arrays.Reverse();
for (int i = 0; i < arrays.Count; i++)
{
    if (arrays.Contains(" "))
    {
        arrays.Remove(" ");
    }
}
Console.WriteLine(String.Join(" ", arrays));