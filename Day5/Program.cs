using System.Text;

Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 5");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var score = 0;
var p2Score = 0;

//a bit cheaty, but.....
//setup stacks
var stacks = new Dictionary<int,Stack<char>>();
for (int a = 1; a <= 9; a++)
{
    stacks[a] = new Stack<char>();
}

//load initial cargo
for(int b = 7; b >= 0; b--)
{
    var char1 = lines[b][1];
    if(char1!=' ') stacks[1].Push(char1);
    var char2 = lines[b][5];
    if (char2 != ' ') stacks[2].Push(char2);
    var char3 = lines[b][9];
    if (char3 != ' ') stacks[3].Push(char3);
    var char4 = lines[b][13];
    if (char4 != ' ') stacks[4].Push(char4);
    var char5 = lines[b][17];
    if (char5 != ' ') stacks[5].Push(char5);
    var char6 = lines[b][21];
    if (char6 != ' ') stacks[6].Push(char6);
    var char7 = lines[b][25];
    if (char7 != ' ') stacks[7].Push(char7);
    var char8 = lines[b][29];
    if (char8 != ' ') stacks[8].Push(char8);
    var char9 = lines[b][33];
    if (char9 != ' ') stacks[9].Push(char9);
}



for (int i = 10; i < lines.Length; i++)
{
    var line = lines[i];
    var split = line.Split(' ');

    var qty = Convert.ToInt32(split[1]);
    var from = Convert.ToInt32(split[3]);
    var to = Convert.ToInt32(split[5]);

    for(var x= 0; x< qty; x++)
    {
        var cargo = stacks[from].Pop();
        stacks[to].Push(cargo);
    }
}

var final = new StringBuilder();
for (int j = 1; j <= 9; j++)
{
    var cargo = stacks[j].Peek();
    final.Append(cargo);
}

Console.WriteLine($"Final tops: {final.ToString()}");



//Part 2, still a bit cheaty, but.....
//setup stacks
var p2Stacks = new Dictionary<int, Stack<char>>();
for (int a = 1; a <= 9; a++)
{
    p2Stacks[a] = new Stack<char>();
}

//load initial cargo
for (int b = 7; b >= 0; b--)
{
    var char1 = lines[b][1];
    if (char1 != ' ') p2Stacks[1].Push(char1);
    var char2 = lines[b][5];
    if (char2 != ' ') p2Stacks[2].Push(char2);
    var char3 = lines[b][9];
    if (char3 != ' ') p2Stacks[3].Push(char3);
    var char4 = lines[b][13];
    if (char4 != ' ') p2Stacks[4].Push(char4);
    var char5 = lines[b][17];
    if (char5 != ' ') p2Stacks[5].Push(char5);
    var char6 = lines[b][21];
    if (char6 != ' ') p2Stacks[6].Push(char6);
    var char7 = lines[b][25];
    if (char7 != ' ') p2Stacks[7].Push(char7);
    var char8 = lines[b][29];
    if (char8 != ' ') p2Stacks[8].Push(char8);
    var char9 = lines[b][33];
    if (char9 != ' ') p2Stacks[9].Push(char9);
}


for (int z = 10; z < lines.Length; z++)
{
    var line = lines[z];
    var split = line.Split(' ');

    var qty = Convert.ToInt32(split[1]);
    var from = Convert.ToInt32(split[3]);
    var to = Convert.ToInt32(split[5]);

    var moving = new char[qty];

    for (var q = 0; q < qty; q++)
    {
        moving[q] = p2Stacks[from].Pop();
    }

    for(var u = qty-1; u >= 0; u--)
    {
        p2Stacks[to].Push(moving[u]);
    }        
}

var p2Final = new StringBuilder();
for (int k = 1; k <= 9; k++)
{
    var cargo = p2Stacks[k].Peek();
    p2Final.Append(cargo);
}




Console.WriteLine($"Part 2 final: {p2Final.ToString()}");



//Stop and wait for enter before exiting
Console.ReadLine();