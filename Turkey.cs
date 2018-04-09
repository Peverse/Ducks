using System;

public interface Turkey
{
    void gobble();
    void fly();
}

public class WildTurkey : Turkey
{
    public void gobble()
    {
        Console.WriteLine("Gobble");
    }

    public void fly()
    {
        Console.WriteLine("I'm flying a short distance");
    }

}
