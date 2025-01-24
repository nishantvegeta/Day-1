List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);

foreach (int i in list)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

int max = list[0];
int min = list[0];

foreach (int i in list)
{
    if (i > max)
    {
        max = i;
    }
    if (i < min)
    {
        min = i;
    }
}
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);


