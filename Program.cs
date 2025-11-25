using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Main();
static void Main()
{
    Console.WriteLine("Write in two numbers to add them! :D");
    decimal aNum;
    decimal bNum;
    Console.Write("Nr.1: ");
    string aStr = Console.ReadLine();
    if (!decimal.TryParse(aStr, out aNum))
    {
        Console.WriteLine("You must write a number!");
        return;
    }
    Console.Write("Nr.2: ");
    string bStr = Console.ReadLine();
    if (!decimal.TryParse(bStr, out bNum))
    {
        Console.WriteLine("You must write a number!");
        return;
    }

    Console.WriteLine($"{aNum} + {bNum} = {MathSum(aNum, bNum)}");
    DenneFunksjonenReturnererIngenting();
    IntroductionRemy();
}
static decimal MathSum(decimal a, decimal b)
{
    return a + b;
}

static void DenneFunksjonenReturnererIngenting()
{
    Console.WriteLine("Denne Funksjonen Returnerer Ingenting");
    return;
}
//Function=Method

static void IntroductionRemy()
{  
    string name = "Remy";
    string pronoun = "He";
    int age = 100;

   Console.WriteLine($"This is {name}, and {pronoun} is {age} years old.");

}




//Introduction(Remy);
//Hobby = Console.readline();
//DoHobbyRemy(Hobby);
//MeetLen();
//Introdution(Len);
//Hobby = Console.readline();
//DoHobbyLen();
//}

