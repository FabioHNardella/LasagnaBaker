namespace LasagnaBaker;
public class Lasagna
{

    public int ExpectedMinutesInOven()
    {
        System.Console.WriteLine("40"); // TODO  Delete this line when posting the code
        return 40;
    }
    public int RemainingMinutesInOven(int time)
    {
        System.Console.WriteLine($"Time remaining in oven: {40 - time}"); // TODO  Delete this line when posting the code
        return 40 - time;
    }
    public int PreparationTimeInMinutes(int layers)
    {
        System.Console.WriteLine($"Preparation time: {layers * 2}");
        return layers * 2;
    }
    public int ElapsedTimeInMinutes(int layersAdded, int timeInOven)
    {
        System.Console.WriteLine($"Elapsed time: {layersAdded * 2 + timeInOven}");
        return layersAdded * 2 + timeInOven;
    }

}
