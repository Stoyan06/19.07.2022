List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
string command;
while((command = Console.ReadLine()) != "end")
{
    List<string> commandSplitter = command.Split().ToList();

    if (commandSplitter[0] == "Delete")

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] == int.Parse(commandSplitter[1]))
            {
                input.Remove(input[i]);
            }
        }
   
    if (commandSplitter[0] == "Insert")
    {
        input.Insert(int.Parse(commandSplitter[2]), int.Parse(commandSplitter[1]));
    }
}

Console.WriteLine(String.Join(" ", input));