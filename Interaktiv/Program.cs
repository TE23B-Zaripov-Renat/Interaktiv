// See https://aka.ms/new-console-template for more information
Console.WriteLine("Du sticker från polisen och är på en korshning. Åker du höger eller vänster?");
string tall = Console.ReadLine();
tall = tall.ToLower();

string animal = """
  __.------~~~-.
,'/             `\
" \  ,..__ | ,_   `\_,
   >/|/   ~~\||`\(`~,~'
   | `\     /'|   \_;
   "   "   "
""";

Console.WriteLine(animal);

if (tall == "höger")
{
    Console.WriteLine("Du lyckades sticka från polis bilarna men stötar på ett helikopter. Kör du in i tunneln eller går ut ur bilen och springer in i skogen? ");

    tall = Console.ReadLine();
    tall = tall.ToLower();
    if (tall == "tunneln")
    {
        Console.WriteLine("Polisen väntar på dig där inne och du blir fångad.Game Over!");
    }
    else if (tall == "skogen")
        Console.WriteLine("Grattis du lyckades rymma.Victory!");
    else
    {
        Console.WriteLine("Du blev catchad av polisen!Grattis!!");
    }

}

else if (tall == "vänster")
{
    Console.WriteLine("Du kör in i staden och väljer vart du ska gömma dig. I ett hotell eller skolan?");
    tall = Console.ReadLine();
    tall = tall.ToLower();
    if (tall == "hotell")
        Console.WriteLine("Kvinnan vid reseptionen ringer polisen och du blir fångad. Game Over");

    else if (tall == "skolan")

        Console.WriteLine("Eleverna stoppade polisen och du lyckades rymma.Victory!");

    else

        Console.WriteLine("Du blev catchad av polisen!Grattis!!");

}


Console.ReadLine();

