// See https://aka.ms/new-console-template for more information

using Ex01;
using System.Globalization;

Console.WriteLine("Digite e a base, respectivamente, separados por espaço: ");
string valores = Console.ReadLine();
string[] separado;
Retangulo r1;
bool apenas = false;
int espacos = 0;

foreach(char c in valores)
{
    switch (c)
    {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9': apenas = true; break;
        case ' ': espacos++; break;
        default: apenas = false; break;
    }
    if (apenas == false)
        break;
}

if (valores != "" && espacos == 1 && apenas == true)
{
    separado = valores.Split();
    r1 = new Retangulo(double.Parse(separado[0]), double.Parse(separado[1]));
}
else
    r1 = new Retangulo(0, 0);

while (valores != "" && espacos == 1 && apenas == true)
{
    Console.WriteLine($"{r1}\nArea = {r1.CalcArea()}\nDiagonal = {r1.CalcDiagonal()}");
    Console.WriteLine("_________________________________________________");
    Console.WriteLine("Digite a base e a altura, respectivamente, separados por espaço: ");
    valores = Console.ReadLine();
    espacos = 0;
    foreach (char c in valores)
    {
        switch (c)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': apenas = true; break;
            case ' ': espacos++; break;
            default: apenas = false; break;
        }
        if (apenas == false)
            break;
    }

    if (valores != "" && espacos == 1 && apenas == true)
    {
        separado = valores.Split();
        r1.SetBase(double.Parse(separado[0]));
        r1.SetAltura(double.Parse(separado[1]));
    }
}
