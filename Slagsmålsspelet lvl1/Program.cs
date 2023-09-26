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

while (namn1 == ""){
 Console.WriteLine("Skriv Namnet för spelare 1 och tryck enter");
 namn1 = Console.ReadLine().ToLower();
}
Console.WriteLine("Välkommen " + namn1);


Console.WriteLine("Skriv Namnet för spelare 2 och tryck enter");
string namn2 = Console.ReadLine().ToLower();

while (namn2 == ""){
 Console.WriteLine("Skriv Namnet för spelare 2 och tryck enter");
 namn2 = Console.ReadLine().ToLower();
}
Console.WriteLine("Välkommen "+ namn2);

int hp1 = 100;
int hp2 = 100;


Console.WriteLine(namn1 + " välj ditt vapen och tryck på enter \n Svärd\n Yxa"); 

String vapen1 = Console.ReadLine().ToLower();
if (vapen1 != "svärd" ){
 Console.WriteLine(namn1 + " skriv ditt vapen och tryck på enter \n Svärd\n Yxa");
 if (Console.ReadLine() == "svärd"){
    vapen1 = "svärd";
 }
 Console.ReadLine().ToLower();

}
Console.WriteLine("\n" + vapen1);






Console.ReadLine();