Console.WriteLine("Advent of Code 2022");
Console.WriteLine("Day 2");

//Solution logic goes here

//Load input array
string[] lines = System.IO.File.ReadAllLines("input.txt");

var counts = new Dictionary<int, int>();
    var score = 0;
var p2Score = 0;
for (int i = 0; i < lines.Length; i++)
{
    var split = lines[i].Split();
    var oppo = split[0];
    var me = split[1];

    switch (me)
    {
        case "X":
            score += 1;
            if (oppo == "C") score += 6;
            else if (oppo == "A") score += 3;

            if (oppo == "A") p2Score += 3;
            else if (oppo == "B") p2Score += 1;
            else p2Score += 2;
            
            break;
        case "Y":
            score += 2;
            if (oppo == "A") score += 6;
            else if (oppo == "B") score += 3;

            if (oppo == "A") p2Score += 4;
            else if (oppo == "B") p2Score += 5;
            else p2Score += 6;

            break;
        case "Z":
            score += 3;
            if (oppo == "B") score += 6;
            else if (oppo == "C") score += 3;

            if (oppo == "A") p2Score += 8;
            else if (oppo == "B") p2Score += 9;
            else p2Score += 7;

            break;
    }
}

Console.WriteLine($"Part 1 total score: {score}");
Console.WriteLine($"Part 2 total score: {p2Score}");




//Stop and wait for enter before exiting
Console.ReadLine();