int numberOfOperatons = int.Parse(Console.ReadLine());
List<string> names = new List<string>();
List<string> notInTheList = new List<string>();
List<string> inTheList = new List<string>();
bool help = true;

for (int i = 0; i < numberOfOperatons; i++)
{
    List<string> input = Console.ReadLine().Split().ToList();
    if (input[2] == "going!" && names.Contains(input[0]) == false)
    {
        names.Add(input[0]);
        help = false;
    }

    if(input[2] == "going!" && names.Contains(input[0]) == true && help == true)
    {
        inTheList.Add(input[0]);
        help = false;
    }

    if(input[2] == "not" && names.Contains(input[0]) == true && help == true)
    {
        names.Remove(input[0]);
        help = false;
    }
    
    if(input[2] == "not" && names.Contains(input[0]) == false && help == true)
    {
        notInTheList.Add(input[0]);
        help = false;
    }

    help = true;
}

if(inTheList.Count != 0)
{
    for(int i = 0; i < inTheList.Count; i++)
    {
        Console.WriteLine(inTheList[i] + " is already in the list!");
    }
}

if (notInTheList.Count != 0)
{
    for (int i = 0; i < notInTheList.Count; i++)
    {
        Console.WriteLine(notInTheList[i] + " is not in the list!");
    }
}

for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}