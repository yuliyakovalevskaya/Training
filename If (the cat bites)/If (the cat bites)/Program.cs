//If (the cat bites), example for making decisions using the if statement
//"a" means minutes for studying maths, "b" means minutes for surfing the net, "c" means minutes for studying Geography.

using System;

int a = 5;
int b = 6;
int c = 7;

ExploreIf();

void ExploreIf()
{
    if (a + b > 10)
    {
        Console.WriteLine("Stop surfing the net or the cat will bite you!");

    }
    else
    {
        Console.WriteLine("You have 10 more minutes and then you need to play with the cat.");
    }
}

if ((a+b+c>10) && (a>b))
{
    Console.WriteLine("You are making progress in maths.");
    Console.WriteLine("You should be proud of yourself.");
}
else
{
    Console.WriteLine("Stop surfing the net or the cat will bite you!");
    Console.WriteLine("You should study maths more.");
}

if ((a+b+c>10) || (a>b))
{
    Console.WriteLine("You are making progress in maths.");
    Console.WriteLine("I am proud of you.");

}
else
{
    Console.WriteLine("Stop surfing the net or the cat will bite you!");
    Console.WriteLine("The cat is near.");

}
