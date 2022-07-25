List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
int command;
int sum = 0;
int memory = 0;
bool help = true;

while(pokemons.Count > 0)
{
    command = int.Parse(Console.ReadLine());
    if (command < 0)
    {
        sum += pokemons[0];
        pokemons[0] = pokemons[pokemons.Count - 1];
        help = false;
    }
    if (help == true)
    {
        if (command > pokemons.Count - 1)
        {
            sum += pokemons[pokemons.Count - 1];
            pokemons[pokemons.Count - 1] = pokemons[0];
            help = false;
        }
       if (help == true)
        {
            memory = pokemons[command];
            pokemons.Remove(pokemons[command]);
            sum += memory;
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= memory)
                {
                    pokemons[i] += memory;
                }
                if (pokemons[i] > memory)
                {
                    pokemons[i] -= memory;
                }
            }
        }
    }
    help = true;
}

Console.WriteLine(sum);