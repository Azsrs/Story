// title screen
Console.WriteLine("Press ENTER to start");
Console.ReadLine();


//namninmatning + reaktion på Frank
Console.WriteLine("What is your name?");
string name = Console.ReadLine().ToLower();

while (name == "frank")
{
    Console.WriteLine("THERE CAN ONLY BE ONE, TRY AGAIN");
    name = Console.ReadLine().ToLower();
}
//om inget namn inmatat, fortsätt fråga
while (name == string.Empty)
{
    Console.WriteLine("What is your name?");
    name = Console.ReadLine().ToLower();
}

//introsekvens
Console.WriteLine("It's time, the crowd is roaring, the lights blaring in your face. No way out now..");
Console.ReadLine();
Console.WriteLine($"You see your opponent on the other side of the ring, you lock eyes for a moment. You don't want to do this.. but the contract is signed");
Console.ReadLine();
Console.WriteLine("The announcer calls for the battle to start and the bell goes off");
Console.ReadLine();
Console.WriteLine("How did you even get here? It was never supposed to be like this");
Console.ReadLine();
Console.WriteLine($"The bell goes off.. it's time. It's do or die.");
Console.ReadLine();
Console.WriteLine("You must fight, the only other option is death. You are equipped with only a dagger and your fighting spirit");
Console.ReadLine();
//Första draget
Console.WriteLine("Your opponent approaches, do you go for the dagger or do you get ready to block an incoming attack? Might it be time to give up?");
string Attack1 = Console.ReadLine().ToLower();
while (Attack1 != "dagger" && Attack1 != "block") //ifall invalid svar
{
    Console.WriteLine("Do you block or do you use your dagger? Or might it be time to give up");
    Attack1 = Console.ReadLine().ToLower();
}
if (Attack1 == "dagger") //Om man väljer dagger
{
    Console.WriteLine("You reach for your blade, and grip it tight in your right hand. Your opponent winds up a haymaker with his right fist aimed straight at your face, using the other hand to guard his face");
    Console.ReadLine();
    Console.WriteLine("You stab toward your opponents' stomach, praying this will somehow end peacefully.\n Lost in thought, you don't notice the opponents' block has shifted down to his stomach.");
    Console.ReadLine();
    Console.WriteLine("Your dagger stabs only his arm and you feel a sudden slam to your head");
    Console.ReadLine();
    Console.WriteLine("Ears ringing, lights blaring.. shit... its really over huh?");
    Console.ReadLine();
    Console.WriteLine("Give up?");

    static void EndGame() //method för att snabbt kunna döda spelaren+stänga programmet 
    {
        Console.WriteLine("Flatline.. Game Over");
        Console.ReadLine();
        Environment.Exit(0);
    }

    string GiveUp = Console.ReadLine().ToLower();
    int InvalidAnswer = 0; //jag deklarerar int innan for-loopen för att kunna använda samma värde i while-loopen
    if (GiveUp != "yes" && GiveUp != "no" && GiveUp != "fight")
    {
        for (InvalidAnswer = 0; InvalidAnswer < 3; InvalidAnswer++) //tre försök att svara rätt annars gameover
        {
            Console.WriteLine("...");
            GiveUp = Console.ReadLine().ToLower();
            if (GiveUp == "yes" || GiveUp == "no" || GiveUp == "fight")
            {
                break;
            }
        }

    }
    if (InvalidAnswer == 3 || GiveUp == "yes")
    {
        EndGame();
    }
    if (GiveUp == "no")
    {
        Console.WriteLine($"You can't give up. At least not yet!\n You try to pull yourself up, the crowd chanting your name {name}, {name}! Maybe all hope is not lost!");
        Console.ReadLine();
        Console.WriteLine("SLAM");
        Console.ReadLine();
        EndGame();
    }
    if (GiveUp == "Fight")
    {
        Console.WriteLine("....");
        Console.ReadLine();
        Console.WriteLine("Something within you just doesn't let up, huh?");
        Console.ReadLine();
        Console.WriteLine("Do or die now, get up and finish this. It's you or him. \n Do you want to try and stab again? Or do you try and tackle him?");
        string FightBack = Console.ReadLine().ToLower();
        while (FightBack != "stab" && FightBack != "tackle")
        {
            Console.WriteLine("Stab or tackle?");
            FightBack = Console.ReadLine();
        }
        
    }
}
else if (Attack1 == "block")
{
    Console.WriteLine("placeholder");
    Console.ReadLine();
    Console.WriteLine("Well, you have to do something. What's so you reach for?");
    string pocket = Console.ReadLine().ToLower();

}


Console.ReadLine();