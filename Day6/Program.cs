Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 6");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var charcount = 0;
char c1 = ' ', c2 = ' ', c3 = ' ', c4 = ' ';

var line = lines[0];
var split = line.ToCharArray();

for (int i = 0; i < split.Length; i++)
{
    c4 = c3;
    c3 = c2;
    c2 = c1;
    c1 = split[i];
    charcount++;
    var distinct = (new char[4] { c1, c2, c3, c4 }).Distinct().Count();
    if (distinct == 4 && charcount >= 4)
    {
        Console.WriteLine($"The start-of-packet marker is at character: {charcount}");
        break;
    }
}


var cArray = new char[14];
charcount = 0;
for (int j = 0; j < split.Length; j++)
{
    var c = split[j];
    for(var a = 13; a>0; a--)
    {
        cArray[a] = cArray[a-1];
    }
    cArray[0] = c;
    charcount++;
    var distinct = cArray.Distinct().Count();
    if(distinct == 14 && charcount >= 14)
    {
        Console.WriteLine($"The start-of-message marker is at character: {charcount}");
        break;
    }

}



//Stop and wait for enter before exiting
Console.ReadLine();