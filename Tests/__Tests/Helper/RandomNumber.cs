namespace Tests.__Tests.Helper;

public static class RandomNumber
{
    public static double GetRandomNumber(int min, int max)
    {
        if (min >= max) throw new ArgumentException("Invalid Parameters");
        return new Random().Next(min, max);
    }
}