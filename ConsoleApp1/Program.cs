
Tamagotchi tamagotchi =new();
Console.WriteLine("Vad vill du namnge din tamagotchi?");
String newname=Console.ReadLine();
tamagotchi.name=newname;
while (tamagotchi.isAlive == true)
{
    Console.Clear();
    tamagotchi.tick();
    tamagotchi.starve();
    tamagotchi.depression();
    if(tamagotchi.words.Count>0){Console.WriteLine(tamagotchi.name+": "+tamagotchi.words[Random.Shared.Next(tamagotchi.words.Count)] );};
    Console.WriteLine("Vad vill du göra med "+tamagotchi.name+".");
    Console.WriteLine("1. Mata den.");
    Console.WriteLine("2. Lära den ett nytt ord.");
    Console.WriteLine("3. Leka med den.");
    Console.WriteLine("4. Se hur den mår.");
    string coise = Console.ReadLine();
    bool s = int.TryParse(coise, out int choise);
    if (s == false)
    {
        Console.WriteLine("Försök igen.");
        Console.ReadKey();
    }
    if (choise == 1)
    {
        tamagotchi.Feed();
        Console.ReadKey();
    }
    if (choise == 2)
    {
        Console.WriteLine("Vilket ord vill du lära "+tamagotchi.name+"?");
        tamagotchi.teach(Console.ReadLine());
        Console.ReadKey();
    }
    if (choise == 3)
    {
        tamagotchi.reduceboredom();
        Console.ReadKey();
    }
    if (choise == 4)
    {
        tamagotchi.stats();
        Console.ReadKey();
    }
}