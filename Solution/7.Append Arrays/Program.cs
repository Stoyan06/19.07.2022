List<string> input = Console.ReadLine().Split("|").ToList();
List<string> arrays = new List<string>();
input.Reverse();

for(int i = 0; i < input.Count; i++)
{
    var temporary = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    foreach(var y in temporary)
    {
        arrays.Add(y);
    }
}

Console.WriteLine(String.Join(" ", arrays));