List<int> waggons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxPassengers = int.Parse(Console.ReadLine());
string command;
int command2;
bool help = true;
while ((command = Console.ReadLine()) != "end")
{
    List<string> commandSplitter = command.Split().ToList();

    if (commandSplitter[0] == "Add")
    {
        waggons.Add(int.Parse(commandSplitter[1]));
    }
    else
    {
        command2 = int.Parse(commandSplitter[0]);

        for(int i = 0; i < waggons.Count; i++)
        {
            if (waggons[i] + command2 <= maxPassengers && help == true)
            {
                waggons[i] += command2;
                help = false;
            }
        }
    }
    help = true;
}

Console.WriteLine(String.Join(" ", waggons));