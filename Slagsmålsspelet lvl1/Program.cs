//SayHello();

//Console.ReadLine();

//static void SayHello()
//{
//  Console.WriteLine("hey");
//}

//asciart();

//static void asciart()
//{
//  Console.WriteLine("");
//}


//SLUMP
// Random generator = new Random();

// int slumptal = generator.Next(10,20);

// Console.WriteLine(slumptal);

//console.Beep

//WILLE-LOOP

// int tal = 100;

// while ( tal > 0)
// {
//     Console.WriteLine(tal);
//     tal--;
// }
// if(namne1 == "")
// {
//     Console.WriteLine("Skriv Namnet för spelare 1 och tryck enter");

//     namne1 = Console.ReadLine().ToLower();
// }
Console.WriteLine("Skriv Namnet för spelare 1 och tryck enter");
string namn1 = Console.ReadLine().ToLower();

while (namn1 == "")
{
    Console.WriteLine("Skriv Namnet för spelare 1 och tryck enter");
    namn1 = Console.ReadLine().ToLower();
}
Console.WriteLine("Välkommen " + namn1);


Console.WriteLine("Skriv Namnet för spelare 2 och tryck enter");
string namn2 = Console.ReadLine().ToLower();

while (namn2 == "")
{
    Console.WriteLine("Skriv Namnet för spelare 2 och tryck enter");
    namn2 = Console.ReadLine().ToLower();
}
Console.WriteLine("Välkommen " + namn2 + "\n\nTryck enter för att börja välja vapen för " + namn1);




//Console.WriteLine(namn1 + " välj ditt vapen och tryck på enter \n Svärd\n Yxa");
bool truue = false;
String vapen1 = Console.ReadLine().ToLower();
while (!truue)
{
    Console.WriteLine(namn1 + " skriv ditt vapen och tryck på enter \n Svärd\n Yxa");
    string weaponChoice1 = Console.ReadLine().ToLower();
    if (weaponChoice1 == "svärd")
    {
        vapen1 = "svärd";
        truue = true;
    }
    if (weaponChoice1 == "yxa")
    {
        vapen1 = "yxa";
        truue = true;
    }

}
Console.WriteLine("\n" + namn1 + " valde " + vapen1 + "\n\nTryck enter för att börja välja vapen för " + namn2);
truue = false;


String vapen2 = Console.ReadLine().ToLower();
while (!truue)
{
    Console.WriteLine(namn2 + " skriv ditt vapen och tryck på enter \n Svärd\n Yxa");
    string weaponChoice2 = Console.ReadLine().ToLower();
    if (weaponChoice2 == "svärd")
    {
        vapen2 = "svärd";
        truue = true;
    }
    if (weaponChoice2 == "yxa")
    {
        vapen2 = "yxa";
        truue = true;
    }

}
Console.WriteLine("\n" + namn2 + " valde " + vapen2);

int hp1 = 100;
int hp2 = 100;

while (hp1 > 0 && hp2 > 0)
{
    if (vapen1 == "svärd")
    {
        if (vapen2 == "svärd")
        {
            hp1 = hp1 - 1;
            hp2 = hp2 - 1;
            Console.WriteLine(namn1 + " har " + hp1 + "            " + namn2 + " har " + hp2);
        }
        else if (vapen2 == "yxa")
        {
            hp1 = hp1 - 2;
            hp2 = hp2 - 1;
            Console.WriteLine(namn1 + " har " + hp1 + "            " + namn2 + " har " + hp2);
        }
    }
    else if (vapen1=="yxa")
    {
        if(vapen2=="yxa")
        {
            hp1= hp1 -2;
            hp2= hp2 -2;
            Console.WriteLine(namn1 + " har " + hp1 + "            " + namn2 + " har " + hp2);
        }
        else if (vapen2 == "svärd")
        {
            hp1 = hp1 - 1;
            hp2 = hp2 - 2;
            Console.WriteLine(namn1 + " har " + hp1 + "            " + namn2 + " har " + hp2);
        }

    }

}

if (hp1==0 & hp2>0)
{
 Console.WriteLine(namn2 + " vann");
}
if(hp1>0 & hp2==0)
{
  Console.WriteLine(namn1 + " vann");  
}
if(hp1==hp2)
{
  Console.WriteLine("Ovagjort");  
}


//while(namn1.Length<=0){}

//wile(hp1>0 || hp2>0){

//}



Console.ReadLine();