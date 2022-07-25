List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
string command;
int memory = 0;
bool invalid = false;
bool invalid2 = false;

while((command = Console.ReadLine()) != "End")
{
    List<string> commandSplitter = command.Split().ToList();

    if (commandSplitter[0] == "Add")
    {
        list.Add(int.Parse(commandSplitter[1]));
    }

    if (commandSplitter[0] == "Insert")
    {
        if (int.Parse(commandSplitter[2]) > list.Count - 1)
        {
            invalid = true;
            invalid2 = true;
        }
        if(invalid2 == false)
        list.Insert(int.Parse(commandSplitter[2]), int.Parse(commandSplitter[1]));
    }

    if (commandSplitter[0] == "Remove")
    {
        if (int.Parse(commandSplitter[1]) > list.Count - 1)
        {
            invalid = true;
            invalid2 = true;
        }
        if (invalid2 == false)
        {
            int index = int.Parse(commandSplitter[1]);
            list.RemoveAt(index);
        }
    }

    if (commandSplitter[0] == "Shift")
    {
        if (commandSplitter[1] == "left")
        {
            for (int i = 0; i < int.Parse(commandSplitter[2]); i++)
            {
                memory = list[0];
                list.RemoveAt(0);
                list.Add(memory);
            }
        }

        if (commandSplitter[1] == "right")
        {
            for (int i = 0; i < int.Parse(commandSplitter[2]); i++)
            {
                memory = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, memory);
            }
        }
    }
    invalid2 = false;
}
if(invalid == true)
{
    Console.WriteLine("Invalid index!");
}
Console.WriteLine(String.Join(" ", list));
