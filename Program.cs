Console.WriteLine("enter the first number");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the second number");
int n2 = int.Parse(Console.ReadLine());

int i, j, s;

Console.WriteLine("Perfect numbers from " + n1 + " to " + n2 + " :");

for (i = n1; i <= n2; i++)
{
    s = 0;
    for (j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            s = s + j;
        }
    }
    if (i == s)
    {
        Console.WriteLine(i);
    }
}