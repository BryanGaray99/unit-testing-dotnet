using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Es_Primo(5)); // Ejemplo de uso
    }

    public static bool Es_Primo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
