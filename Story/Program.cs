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
if (Attack1 == "dagger") //väljer dagger
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

    void EndGame() //method för att snabbt kunna döda spelaren+stänga programmet !!!Color change dont forget
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
            if (GiveUp == "yes" || GiveUp == "no" || GiveUp == "fight") //incase man svarar rätt efter man svarat fel en gång
            {
                break;
            }
        }

    }
    if (InvalidAnswer == 3 || GiveUp == "yes") //ger upp
    {
        EndGame();
    }
    else if (GiveUp == "no")
    {
        Console.WriteLine($"You can't give up. At least not yet!\n You try to pull yourself up, the crowd chanting your name {name}, {name}! Maybe all hope is not lost!");
        Console.ReadLine();
        Console.WriteLine("SLAM");
        Console.ReadLine();
        EndGame();
    }
    else if (GiveUp == "fight")
    {
        Console.WriteLine("....");
        Console.ReadLine();
        Console.WriteLine("Something within you just doesn't let up, huh?");
        Console.ReadLine();
        Console.WriteLine("A fire within you has been lit, you will not die!");
        Console.ReadLine();
        Console.WriteLine("You fly up from the ground, ready to fight for survival");
        Console.ReadLine();
        Console.WriteLine("Punch! Punch! Punch! Every hit like a small victory. You can't stop, you can't die!");
        Console.ReadLine();
        Console.WriteLine($"The crowd is chanting {name}, {name}!");
        Console.ReadLine();
        Console.WriteLine("Your opponent is down, but you can't stop punching.");
        Console.ReadLine();
        Console.WriteLine("The crowd isnt chanting anymore, but you can't stop punching.");
        Console.ReadLine();
        Console.WriteLine("You win!"); //color change??
        Console.ReadLine();
        Environment.Exit(0);
    }
}
else if (Attack1 == "block")
{
    Console.WriteLine("You weave to the side and bring your arms up. His haymaker misses, leaving him wide open");
    Console.ReadLine();
    Console.WriteLine("Now's your chance! Do you try to hit him unconcius or do you stab him?");
    string Chance = Console.ReadLine().ToLower();
    while (Chance != "hit" && Chance != "stab")
    {
        Console.WriteLine("hit or stab?");
        Chance = Console.ReadLine().ToLower();
    }
    if (Chance == "hit")
    {
        Console.WriteLine("You successfully hit him down to the ground");
        Console.ReadLine();
        Console.WriteLine("You can finish him off, secure the victory. Or do you leave him down and hope he gives up");
        string FinishHim = Console.ReadLine().ToLower();
        while (FinishHim != "finish" && FinishHim != "leave")
        {
            Console.WriteLine("Finish or Leave?");
            FinishHim = Console.ReadLine();
        }
        if (FinishHim == "finish")
        {
            Console.WriteLine("Your opponent lies in front of you, he's not moving.. yet.\n You can't be too safe");
            Console.ReadLine();
            Console.WriteLine("You grab your dagger and walk toward him.. You're not a bad guy, you just don't want to die");
            Console.ReadLine();
            Console.WriteLine("As you lunge your arm toward your opponent and plant your knife in his stomach he suddenly comes to");
            Console.ReadLine();
            Console.WriteLine("He looks at you in horror for a few seconds. You're frozen still, you can't believe what you have done");
            Console.ReadLine();
            Console.WriteLine("Before you can even react; the look of horror from your opponent grows into a smile as you feel a sharp pain in your chest");
            Console.ReadLine();
            Console.WriteLine("As you realize what have just happened. You can't help but smile as well");
            Console.ReadLine();
            Console.WriteLine("As you drift away, opponent by your side, you feel a sense of calm. You somehow feel absolved of your sins");
            Console.ReadLine();
            Console.WriteLine("Game over, DRAW!"); //color
            Console.ReadLine();
            Environment.Exit(0);
        }
        if (FinishHim == "leave")
        {
            Console.WriteLine("No need to rub it in, he won't get up. He too wants this to be over, right?");
            Console.ReadLine();
            Console.WriteLine("The announcer starts counting: 1");
            for (int i = 2; i < 10; i++) //for loop för att jag kan
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            Console.WriteLine("WIN by KO");
        }
    }


}


Console.ReadLine();