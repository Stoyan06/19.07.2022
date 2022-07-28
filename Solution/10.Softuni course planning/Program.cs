List<string> input = Console.ReadLine().Split(", ").ToList();
string command;
string memory;
int recogniser = 0;

while((command = Console.ReadLine()) != "course start")
{
    List<string> commandSplitter = command.Split(":").ToList();

    if (commandSplitter[0] == "Add")
    {
        if (input.Contains(commandSplitter[1]))
        {
            //dont add the element
        }
        else
        {
            input.Add(commandSplitter[1]);
        }
    }

    if (commandSplitter[0] == "Insert")
    {
        if (input.Contains(commandSplitter[1]))
        {
            //dont instet the element
        }
        else
        {
            input.Insert(int.Parse(commandSplitter[2]), commandSplitter[1]);
        }
    }

    if (commandSplitter[0] == "Remove")
    {
        if (input.Contains(commandSplitter[1]))
        {
            input.Remove(commandSplitter[1]);
        }
    }

    if (commandSplitter[0] == "Swap")
    {
        if (input.Contains(commandSplitter[1]) && input.Contains(commandSplitter[2]))
        {
            memory = commandSplitter[1];

            for(int i = 0; i < input.Count; i++)
            {
                if (input[i] == commandSplitter[1])
                {
                    input[i] = commandSplitter[2];
                    recogniser = i;
                }
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == commandSplitter[2] && recogniser != i)
                {
                    input[i] = memory;
                }
            }

            if (input.Contains(commandSplitter[1] + "-Exercise"))
            {
                input.Remove(commandSplitter[1] + "-Exercise");
                input.Insert(input.IndexOf(commandSplitter[1]) + 1, commandSplitter[1] + "-Exercise");
            }

            if (input.Contains(commandSplitter[2] + "-Exercise"))
            {
                input.Remove(commandSplitter[2] + "-Exercise");
                input.Insert(input.IndexOf(commandSplitter[2]) + 1, commandSplitter[2] + "-Exercise");
            }
        }
    }

    if (commandSplitter[0] == "Exercise")
    {
        if (input.Contains(commandSplitter[1]))
        {
            for(int i = 0; i < input.Count; i++)
            {
                if (input[i] == commandSplitter[1])
                {
                    input.Insert(i + 1, commandSplitter[1] + "-Exercise");
                }
            }
        }
        else
        {
            input.Add(commandSplitter[1]);
            input.Add(commandSplitter[1] + "-Exercise");
        }
    }
}

for(int i = 0; i < input.Count; i++)
{
    int a = i + 1;
    Console.WriteLine(a + "." + input[i]);
}