// Tabliczka mnożenia
/*
for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.Write(i*j + "\t");
    }
    Console.WriteLine("");
}*/

// Zadania - PRE - Narusyj poniższe kształty
/*
*
**
***

***
**
*

  *
 **
***

 */
/*
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = n - i - 1; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}*/


// Zad 2
/*
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    if (i % 2 == 0)
    {
        Console.Write("--");
    }
    else
    {
        Console.Write("||");
    }
}*/

// Zad 3
/*
char znak = '|';
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    Console.Write("*");
    for (int j = 0; j < i; j++)
    {
        Console.Write(znak);
    }
    znak = (znak == '|') ? '-' : '|';
}
*/

// Zad 4

using System.Diagnostics.Tracing;
/*
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j - i == n/2 || i - j == n/2 || i + j == n/2 + 2 || i + j == 3*(n/2)+2)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}*/

// Zad 5
/*
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    if (i == n / 2 + 1)
    {
        for (int j = 1; j < n / 2 + 1; j++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int j = 1; j < n / 2 + 1; j++)
        {
            Console.Write("-");
        }
    }
    else
    {
        for (int j = 1; j < n / 2 + 1; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j == n/2 + 1)           Console.Write("*");
        else if (i == n / 2 + 1)    Console.Write("-");
        else                        Console.Write(" ");
    }
    Console.WriteLine();
}*/

// Zad 6
/*
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == n-j+1) Console.Write("?");
        else if (i == j) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}*/


// Zad 7
/*
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == 1 || i == n || j == 1 || j == n || (i == n/2 + 1 && j == n/2 + 1)) Console.Write("*");
        else Console.Write(" ");
    }
    Console.WriteLine();
}*/

//Console.ReadKey();

