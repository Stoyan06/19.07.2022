List<string> input = Console.ReadLine().Split().ToList();
string command;

while((command = Console.ReadLine()) != "3:1")
{
    List<string> commandSplitter = command.Split().ToList();

    if (commandSplitter[0] == "merge")
    {
        for(int i = int.Parse(commandSplitter[1]); i <= int.Parse(commandSplitter[2]); i++)
        {
            input[int.Parse(commandSplitter[1])] += input[i];
            for (int y = int.Parse(commandSplitter[1]) + 1; y <= int.Parse(commandSplitter[2]);y++)
            {
                input.Remove(input[y]);
            }
        }
    }
}