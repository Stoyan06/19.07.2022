List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();
int specialNumber = data[0];
int power = data[1];
int index = 0;
bool stop = false;

for(int q = 0; q < input.Count -1; q++)
{
    if (input[q] == specialNumber && stop == false)
    {
        index = q;
        stop = true;
    }
}
//1 2 2 4 2 2 2 9
int n = index - 1;

for (int k = 0; k < power; k++)
{
    int help1 = input[n];
    input.Remove(help1);
    n--;
}

int f2 = index + 1;
for (int f = 0; f < power;f++)
{
    int help2 = input[f2];
    input.Remove(help2);
    f2++;
}

int sum = 0;
for(int x = 0; x < input.Count; x++)
{
    sum += input[x];
}

Console.WriteLine(sum);

Console.WriteLine(String.Join(" ", input));