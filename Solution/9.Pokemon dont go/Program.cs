List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
int sum = 0;
int memory = 0;

while (input.Count > 0)
{
    int index = int.Parse(Console.ReadLine());
    if (index < 0)
    {
        int mma = input[0];
        sum += mma;
        input[0] = input[input.Count - 1];

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] <= mma)
            {
                input[i] += mma;
            }

            else
            {
                input[i] -= mma;
            }
        }
    }

    else if (index > input.Count - 1)
    {
        sum += input[input.Count - 1];
        int mmb = input[input.Count - 1];
        input[input.Count - 1] = input[0];

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] <= mmb)
            {
                input[i] += mmb;
            }

            else
            {
                input[i] -= mmb;
            }
        }
    }
    else
    {
        memory = input[index];
        sum += memory;
        input.RemoveAt(index);

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] <= memory)
            {
                input[i] += memory;
            }

            else
            {
                input[i] -= memory;
            }
        }
    }
}

Console.WriteLine(sum);