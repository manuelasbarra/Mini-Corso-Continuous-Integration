// See https://aka.ms/new-console-template for more information
public class Calcolatrice
{
    public int SommaInteri(int a, int b)
    {
        if (a < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a));
        }
        if (b < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b));
        }

        return a - b;
    }

}
