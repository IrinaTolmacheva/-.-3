// Задача 64
int M = 1;
int N = 5;

Console.WriteLine("Значение M: " + M.ToString());
Console.WriteLine("Значение N: " + N.ToString());
Console.WriteLine();


Console.Write("Задача 64\n\n");


for (int i = M; i <= N; i++)
{
    Console.Write(i);
    if (i != N) Console.Write(", ");
}

// Задача 66

Console.Write("\n\nЗадача 66\n\n");

int Sum = 0;

for (int i = M; i <= N; i++)
{
    Sum += i;
}

Console.Write(Sum);

// Задача 68

Console.Write("\n\nЗадача 68\n\n");

static int A(int m, int n)
{
    int answer;
    if (m == 0) answer = n + 1;
    else if (n == 0) answer = A(m - 1, 1);
    else answer = A(m - 1, A(m, n - 1));
    return answer;
}

Console.WriteLine(A(M, N));