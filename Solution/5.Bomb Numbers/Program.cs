List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
int specialNumber = data[0];
int power = data[1];
int index = 0;
int sum = 0;
int times = 0;

for(int i = 0; i < input.Count; i++)
{
    if (input[i] == specialNumber && input[i - 1] != input[i] && input[i + 1] != input[i])
    {
        times++;
    }
}

if(times == 0)
{
    times = 1;
}
for (int i = 0; i < times; i++)
{
    for (int q = 0; q < input.Count; q++)
    {
        if (input[q] == specialNumber)
        {
            index = q;
            break;
        }
    }

    int remover1 = index - power;

    if (remover1 < 0)
    {
        remover1 = 0;
    }

    for (int k = remover1; k < index; k++)
    {
        input.RemoveAt(remover1);
    }

    int f2 = index + 1;

    for (int f = 0; f < power; f++)
    {
        if (f2 > input.Count - 1)
        {
            input.RemoveAt(input.Count - 1);
            break;
        }
        //1 4 2 2 2 9
        f2--;
        input.RemoveAt(f2);
        f2++;
    }

    for (int v = 0; v < input.Count; v++)
    {
        if (input[v] == specialNumber)
        {
            input.RemoveAt(v);
        }
    }

    sum = 0;
    for (int x = 0; x < input.Count; x++)
    {
        sum += input[x];
    }
}
Console.WriteLine(sum);

Console.WriteLine(String.Join(" ", input));