List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = 0; i == 0;)
{
    if (input1[0] > input2[0])
    {
        input1.Add(input2[0]);
        input1.Add(input1[0]);
    }

    if (input2[0] > input1[0])
    {
        input2.Add(input1[0]);
        input2.Add(input2[0]);
    }

    input1.RemoveAt(0);
    input2.RemoveAt(0);

    if(input1.Count == 0)
    {
        Console.WriteLine("Second player wins! Sum: " + input2.Sum());
        return;
    }

    if (input2.Count == 0)
    {
        Console.WriteLine("First player wins! Sum: " + input1.Sum());
        return;
    }
}