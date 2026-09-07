using System;
public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words=[];
    private bool isAlive=true;
    public string name="";
    public void Feed()
    {
        Console.WriteLine(name +" ate and became less hungry.");
        hunger -=0;
        if (hunger < 0)
        {
            hunger=0;
        }
    }
    public void tick()
    {
        boredom++;
        hunger++;
    }
    public void teach(string word)
    {
        Console.WriteLine(name +" have learned to say "+ word);
        words.Add(word);
        reduceboredom();
    }
    public void reduceboredom()
    {
        boredom-=2;
        if (boredom < 0)
        {
            boredom=0;
        }
    }
    public void stats()
    {
        Console.WriteLine();
    }
}
